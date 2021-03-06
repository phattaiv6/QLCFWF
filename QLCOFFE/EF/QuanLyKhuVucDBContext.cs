namespace QLCOFFE.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKhuVucDBContext : DbContext
    {
        public QuanLyKhuVucDBContext()
            : base("name=QuanLyKhuVucDBContext")
        {
        }

        public virtual DbSet<KHUVUC> KHUVUCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
