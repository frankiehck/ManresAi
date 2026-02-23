using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace Manres.Api.Services;

public sealed class SchemaInitializer
{
    private readonly IConfiguration _config;
    private readonly ILogger<SchemaInitializer> _logger;

    public SchemaInitializer(IConfiguration config, ILogger<SchemaInitializer> logger)
    {
        _config = config;
        _logger = logger;
    }

    public async Task ApplyIfEnabledAsync()
    {
        var enabled = _config.GetValue<bool>("Schema:ApplyOnStartup");
        if (!enabled)
        {
            return;
        }

        var scriptPath = _config.GetValue<string>("Schema:ScriptPath") ?? "../../sql/Manres.Schema.sql";
        if (!File.Exists(scriptPath))
        {
            _logger.LogWarning("Schema script file not found at {Path}", scriptPath);
            return;
        }

        var connectionString = _config.GetConnectionString("Manres");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            _logger.LogWarning("ConnectionStrings:Manres is missing. Skipping schema apply.");
            return;
        }

        var script = await File.ReadAllTextAsync(scriptPath);
        var batches = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase)
            .Select(b => b.Trim())
            .Where(b => !string.IsNullOrWhiteSpace(b))
            .ToArray();

        await using var conn = new SqlConnection(connectionString);
        await conn.OpenAsync();

        foreach (var batch in batches)
        {
            await using var cmd = conn.CreateCommand();
            cmd.CommandText = batch;
            await cmd.ExecuteNonQueryAsync();
        }

        _logger.LogInformation("Schema script applied successfully from {Path}", scriptPath);
    }
}
