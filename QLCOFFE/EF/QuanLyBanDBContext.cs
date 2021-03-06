namespace QLCOFFE.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyBanDBContext : DbContext
    {
        public QuanLyBanDBContext()
            : base("name=QuanLyBanDBContext1")
        {
        }

        public virtual DbSet<BAN> BANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
