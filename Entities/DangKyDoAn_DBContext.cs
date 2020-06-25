using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DangKyDoAn_DBContext : DbContext
    {
        public DangKyDoAn_DBContext() : base("DKDoAnConnectionString")
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<DoAn> DoAns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
