using Microsoft.EntityFrameworkCore;
using Ni_Soft.ToDoApi.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ToDoApiDbContext");




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSqlite<ToDoApiDbContext>(connectionString);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = builder.Environment.ApplicationName, Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{builder.Environment.ApplicationName} v1"));
}


app.MapFallback(() => Results.Redirect("/swagger"));

app.MapGet("/todos", async (ToDoApiDbContext db) =>
{
    return await db.Todos.ToListAsync();
});
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ToDoApiDbContext>();
    dbContext.Migrate();
}
app.Run();

