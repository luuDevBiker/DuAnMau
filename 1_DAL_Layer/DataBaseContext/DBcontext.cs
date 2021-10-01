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
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Hang> Hangs { get; set; }
    }
}
