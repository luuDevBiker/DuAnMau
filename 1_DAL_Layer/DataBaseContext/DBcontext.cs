using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_Layer.Entities;
using _1_DAL_Layer.Entitys;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_Layer.DataBaseContext
{
    public class DBcontext : DbContext
    {
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DEVELOPER\\SQLEXPRESS;Integrated Security=True;Initial Catalog=DuAnMau");
            }
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customer_Order> Customer_Orders { get; set; }
        public DbSet<Customer_Order_Details> Customer_Order_Details { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer_Order_Details>()
                .HasKey(cod => new { cod.CO_Code, cod.Prd_Code });
        }
    }
}
