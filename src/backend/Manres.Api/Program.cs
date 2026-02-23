using Manres.Api;
using Manres.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("frontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://127.0.0.1:5173", "http://localhost:8080")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddDbContext<ManresDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Manres")));

builder.Services.AddScoped<DynamicCrudService>();
builder.Services.AddSingleton<SchemaInitializer>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var schema = scope.ServiceProvider.GetRequiredService<SchemaInitializer>();
    await schema.ApplyIfEnabledAsync();
}

app.UseHttpsRedirection();
app.UseCors("frontend");
app.MapControllers();
app.Run();
