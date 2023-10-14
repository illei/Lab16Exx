using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exx.Models
{
    internal class AutovehiculDbContext:DbContext
    {
        public DbSet<Autovehicul> Autovehicule { get; set; }
        public DbSet<Producator> Producatori { get; set; }
        public AutovehiculDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\illei\source\repos\Laboratorul 16\Lab16Exxx\Lab16Exx\Lab16Exx\Database1.mdf;Integrated Security=True");
        }
    }
}
