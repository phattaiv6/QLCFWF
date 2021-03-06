namespace QLCOFFE.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyThucDonDBContext : DbContext
    {
        public QuanLyThucDonDBContext()
            : base("name=QuanLyThucDonDBContext")
        {
        }

        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
