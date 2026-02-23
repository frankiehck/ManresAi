using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using System.Text.Json;

namespace Manres.Api.Services;

public sealed class DynamicCrudService
{
    private readonly DbContext _db;

    public DynamicCrudService(ManresDbContext db)
    {
        _db = db;
    }

    public async Task<CrudResult> ListAsync(string entityName, int skip, int take)
    {
        var entityType = FindEntityType(entityName);
        if (entityType == null)
        {
            return CrudResult.Fail($"Unknown entity '{entityName}'.");
        }

        take = Math.Clamp(take, 1, 500);
        var set = _db.Set(entityType.ClrType);
        var data = await set.AsNoTracking().Skip(Math.Max(0, skip)).Take(take).ToListAsync();
        return CrudResult.Ok(data);
    }

    public async Task<CrudResult> GetByIdAsync(string entityName, string id)
    {
        var entityType = FindEntityType(entityName);
        if (entityType == null)
        {
            return CrudResult.Fail($"Unknown entity '{entityName}'.");
        }

        var pk = entityType.FindPrimaryKey();
        if (pk == null || pk.Properties.Count != 1)
        {
            return CrudResult.Fail($"Entity '{entityType.GetTableName()}' has no single-column primary key.");
        }

        var keyProp = pk.Properties[0].PropertyInfo;
        if (keyProp == null)
        {
            return CrudResult.Fail("Primary key metadata missing property info.");
        }

        var key = ConvertFromString(id, keyProp.PropertyType);
        if (key == null)
        {
            return CrudResult.Fail($"Invalid id '{id}' for key type {keyProp.PropertyType.Name}.");
        }

        var entity = await _db.FindAsync(entityType.ClrType, key);
        return entity == null ? CrudResult.NotFound($"Record not found for id '{id}'.") : CrudResult.Ok(entity);
    }

    public async Task<CrudResult> CreateAsync(string entityName, JsonElement body)
    {
        var entityType = FindEntityType(entityName);
        if (entityType == null)
        {
            return CrudResult.Fail($"Unknown entity '{entityName}'.");
        }

        var entity = Activator.CreateInstance(entityType.ClrType);
        if (entity == null)
        {
            return CrudResult.Fail($"Could not create entity instance for '{entityName}'.");
        }

        var applyResult = ApplyBody(entityType, entity, body, isUpdate: false);
        if (!applyResult.Success)
        {
            return applyResult;
        }

        _db.Add(entity);
        await _db.SaveChangesAsync();
        return CrudResult.Ok(entity);
    }

    public async Task<CrudResult> UpdateAsync(string entityName, string id, JsonElement body)
    {
        var entityType = FindEntityType(entityName);
        if (entityType == null)
        {
            return CrudResult.Fail($"Unknown entity '{entityName}'.");
        }

        var pk = entityType.FindPrimaryKey();
        if (pk == null || pk.Properties.Count != 1)
        {
            return CrudResult.Fail($"Entity '{entityType.GetTableName()}' has no single-column primary key.");
        }

        var keyProp = pk.Properties[0].PropertyInfo;
        if (keyProp == null)
        {
            return CrudResult.Fail("Primary key metadata missing property info.");
        }

        var key = ConvertFromString(id, keyProp.PropertyType);
        if (key == null)
        {
            return CrudResult.Fail($"Invalid id '{id}' for key type {keyProp.PropertyType.Name}.");
        }

        var entity = await _db.FindAsync(entityType.ClrType, key);
        if (entity == null)
        {
            return CrudResult.NotFound($"Record not found for id '{id}'.");
        }

        var applyResult = ApplyBody(entityType, entity, body, isUpdate: true);
        if (!applyResult.Success)
        {
            return applyResult;
        }

        await _db.SaveChangesAsync();
        return CrudResult.Ok(entity);
    }

    public async Task<CrudResult> DeleteAsync(string entityName, string id)
    {
        var entityType = FindEntityType(entityName);
        if (entityType == null)
        {
            return CrudResult.Fail($"Unknown entity '{entityName}'.");
        }

        var pk = entityType.FindPrimaryKey();
        if (pk == null || pk.Properties.Count != 1)
        {
            return CrudResult.Fail($"Entity '{entityType.GetTableName()}' has no single-column primary key.");
        }

        var keyProp = pk.Properties[0].PropertyInfo;
        if (keyProp == null)
        {
            return CrudResult.Fail("Primary key metadata missing property info.");
        }

        var key = ConvertFromString(id, keyProp.PropertyType);
        if (key == null)
        {
            return CrudResult.Fail($"Invalid id '{id}' for key type {keyProp.PropertyType.Name}.");
        }

        var entity = await _db.FindAsync(entityType.ClrType, key);
        if (entity == null)
        {
            return CrudResult.NotFound($"Record not found for id '{id}'.");
        }

        _db.Remove(entity);
        await _db.SaveChangesAsync();
        return CrudResult.Ok();
    }

    private CrudResult ApplyBody(IEntityType entityType, object entity, JsonElement body, bool isUpdate)
    {
        if (body.ValueKind != JsonValueKind.Object)
        {
            return CrudResult.Fail("Request body must be a JSON object.");
        }

        var pkPropertyName = entityType.FindPrimaryKey()?.Properties.FirstOrDefault()?.PropertyInfo?.Name;

        foreach (var jsonProp in body.EnumerateObject())
        {
            var clrProperty = FindClrProperty(entityType.ClrType, jsonProp.Name);
            if (clrProperty == null || !clrProperty.CanWrite)
            {
                continue;
            }

            if (isUpdate && pkPropertyName != null && clrProperty.Name.Equals(pkPropertyName, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (!TryConvertFromJson(jsonProp.Value, clrProperty.PropertyType, out var converted))
            {
                return CrudResult.Fail($"Invalid value for field '{jsonProp.Name}'.");
            }

            clrProperty.SetValue(entity, converted);
        }

        return CrudResult.Ok();
    }

    private IEntityType? FindEntityType(string name)
    {
        return _db.Model.GetEntityTypes().FirstOrDefault(e =>
            string.Equals(e.GetTableName(), name, StringComparison.OrdinalIgnoreCase) ||
            string.Equals(e.ClrType.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    private static PropertyInfo? FindClrProperty(Type type, string name)
    {
        return type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .FirstOrDefault(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    private static object? ConvertFromString(string value, Type targetType)
    {
        var t = Nullable.GetUnderlyingType(targetType) ?? targetType;

        try
        {
            if (t == typeof(string)) return value;
            if (t == typeof(int)) return int.Parse(value);
            if (t == typeof(long)) return long.Parse(value);
            if (t == typeof(short)) return short.Parse(value);
            if (t == typeof(decimal)) return decimal.Parse(value);
            if (t == typeof(bool)) return bool.Parse(value);
            if (t == typeof(DateTime)) return DateTime.Parse(value);
            return Convert.ChangeType(value, t);
        }
        catch
        {
            return null;
        }
    }

    private static bool TryConvertFromJson(JsonElement value, Type targetType, out object? converted)
    {
        var t = Nullable.GetUnderlyingType(targetType) ?? targetType;

        try
        {
            if (value.ValueKind == JsonValueKind.Null)
            {
                converted = null;
                return Nullable.GetUnderlyingType(targetType) != null || !targetType.IsValueType;
            }

            if (t == typeof(string))
            {
                converted = value.GetString();
                return true;
            }

            if (t == typeof(int))
            {
                converted = value.GetInt32();
                return true;
            }

            if (t == typeof(long))
            {
                converted = value.GetInt64();
                return true;
            }

            if (t == typeof(short))
            {
                converted = value.GetInt16();
                return true;
            }

            if (t == typeof(decimal))
            {
                converted = value.GetDecimal();
                return true;
            }

            if (t == typeof(bool))
            {
                converted = value.GetBoolean();
                return true;
            }

            if (t == typeof(DateTime))
            {
                converted = value.GetDateTime();
                return true;
            }

            converted = JsonSerializer.Deserialize(value.GetRawText(), t);
            return true;
        }
        catch
        {
            converted = null;
            return false;
        }
    }
}

public sealed record CrudResult(bool Success, object? Payload = null, string? Error = null, bool IsNotFound = false)
{
    public static CrudResult Ok(object? payload = null) => new(true, payload);
    public static CrudResult Fail(string error) => new(false, null, error);
    public static CrudResult NotFound(string error) => new(false, null, error, true);
}
