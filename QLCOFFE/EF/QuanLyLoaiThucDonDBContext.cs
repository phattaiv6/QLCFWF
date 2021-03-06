namespace QLCOFFE.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyLoaiThucDonDBContext : DbContext
    {
        public QuanLyLoaiThucDonDBContext()
            : base("name=QuanLyLoaiThucDonDBContext")
        {
        }

        public virtual DbSet<LOAIHANGHOA> LOAIHANGHOAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
