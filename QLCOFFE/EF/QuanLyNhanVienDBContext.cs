namespace QLCOFFE.DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyNhanVienDBContext : DbContext
    {
        

        public QuanLyNhanVienDBContext()
            : base("name=QuanLyNhanVienDBContext")
        {

        }

        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
