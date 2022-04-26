using Microsoft.EntityFrameworkCore;
using nnnttt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nnnttt.DataAcess
{
    public class AddDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U2JK4CO;Database=EmployeeDb;Integrated Security = true;");
        }

        public DbSet<Employee> Company { get; set; }
    }
}
