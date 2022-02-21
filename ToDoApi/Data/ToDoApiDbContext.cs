using Microsoft.EntityFrameworkCore;
using Ni_Soft.ToDoApi.Data.Entities;

namespace Ni_Soft.ToDoApi.Data
{
    public class ToDoApiDbContext : DbContext
    {
        private readonly ILogger<ToDoApiDbContext> _logger;
        public ToDoApiDbContext(DbContextOptions options, ILogger<ToDoApiDbContext> logger)
            : base(options) => _logger = logger;

        // Liste des tâches
        public DbSet<TodoEntity> Todos => Set<TodoEntity>();

        // Exécuter les commandes de migration
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
