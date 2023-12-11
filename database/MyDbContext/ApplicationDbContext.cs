using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.Models;
using Microsoft.EntityFrameworkCore;

namespace database.MyDbContext
{
    internal class ApplicationDbContext : DbContext
    {
        // initialize a connection inside the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-853KEKM\\MSSQLS;Initial Catalog=MakeenCompany;Integrated Security=True;");
        }

        public DbSet <Employee> Employees { get; set; }
    }
}
