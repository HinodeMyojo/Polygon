using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Planet> Planets => Set<Planet>(); // Представляет набор объектов, которые хранятся в базе данных
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=planets.db");
        }
    }
}
