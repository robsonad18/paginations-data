using Microsoft.EntityFrameworkCore;
using paginations_data.Models;

namespace paginations_data.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Todo> Todos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");

    }
}