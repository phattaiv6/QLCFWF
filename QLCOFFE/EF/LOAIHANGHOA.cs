namespace QLCOFFE.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIHANGHOA")]
    public partial class LOAIHANGHOA
    {
        [Key]
        public int MALH { get; set; }

        [StringLength(100)]
        public string TENLH { get; set; }

        [StringLength(100)]
        public string MOTA { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }
    }
}
