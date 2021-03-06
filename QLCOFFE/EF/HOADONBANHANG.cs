namespace QLCOFFE.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBANHANG")]
    public partial class HOADONBANHANG
    {
        [Key]
        public int MAHDBH { get; set; }

        [StringLength(100)]
        public string MANV { get; set; }

        public int? MABAN { get; set; }

        public int? GIASP { get; set; }

        [StringLength(100)]
        public string MAKH { get; set; }

        public DateTime? THOIGIAN { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }

        public int? GIAMGIA { get; set; }

        public int? TONGTIEN { get; set; }
        public string MOTA { get; set; }
    }
}
