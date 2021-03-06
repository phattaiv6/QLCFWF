namespace QLCOFFE.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [Key]
        [StringLength(100)]
        public string MAKH { get; set; }

        [StringLength(100)]
        public string TENKH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(100)]
        public string MALKH { get; set; }

        [StringLength(100)]
        public string TENLKH { get; set; }

        public int? SDT { get; set; }

        public int? DIEMTL { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }
    }
}
