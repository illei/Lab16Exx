using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exx.Models
{
    internal class StudentDBContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        // public  DbSet<Major> Major {  get; set; }
        public StudentDBContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\illei\source\repos\Laboratorul 16\Lab16Exxx\Lab16Exx\Lab16Exx\SudentDB2.mdf"";Integrated Security=True");
        }
    }
   
}
