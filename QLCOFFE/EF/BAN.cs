namespace QLCOFFE.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAN")]
    public partial class BAN
    {
        [Key]
        public int MABAN { get; set; }

        [StringLength(100)]
        public string TENBAN { get; set; }

        [StringLength(100)]
        public string MAKV { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }
    }
}
