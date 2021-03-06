namespace QLCOFFE.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyHoaDonDBContext : DbContext
    {
        public QuanLyHoaDonDBContext()
            : base("name=QuanLyHoaDonDBContext")
        {
        }

        public virtual DbSet<HOADONBANHANG> HOADONBANHANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
