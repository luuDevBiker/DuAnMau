using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<Employee> NhanViens { get; set; }
        public DbSet<Customer> KhachHangs { get; set; }
        public DbSet<Products> Hangs { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    //All the telephones must be deleteded alongside a Person.
        //    //Deleting a telephone must not delete the person it refers to.
        //    builder.Entity<Employee>()
        //        .HasMany(p => p.Products)
        //        .WithOne(p => p.Employee);
        //    builder.Entity<Employee>()
        //        .HasMany(p => p.Customer)
        //        .WithOne(p => p.Employee);
        //}
    }
}
