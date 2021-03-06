namespace QLCOFFE.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [Key]
        public int MAHH { get; set; }

        [StringLength(100)]
        public string TENHH { get; set; }

        public int? MALH { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANH { get; set; }

        public int? GIASP { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }
    }
}
