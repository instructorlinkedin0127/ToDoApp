using Microsoft.EntityFrameworkCore;
using Ni_Soft.ToDoApi.Data.Entities;

namespace Ni_Soft.ToDoApi.Data
{
    public class ToDoApiDbContext : DbContext
    {
        private readonly ILogger<ToDoApiDbContext> _logger;
        public ToDoApiDbContext(DbContextOptions options, ILogger<ToDoApiDbContext> logger)
            : base(options) => _logger = logger;

        public DbSet<TodoEntity> Todos => Set<TodoEntity>();


        public void Migrate()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to migrate database", ex);
            }
        }
    }
}
