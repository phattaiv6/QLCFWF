namespace QLCOFFE.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKhachHangDBContext : DbContext
    {
        public QuanLyKhachHangDBContext()
            : base("name=QuanLyKhachHangDBContext")
        {
        }

        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
