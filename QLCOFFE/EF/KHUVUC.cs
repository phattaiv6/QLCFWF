namespace QLCOFFE.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUVUC")]
    public partial class KHUVUC
    {
        [Key]
        [StringLength(100)]
        public string MAKV { get; set; }

        [StringLength(100)]
        public string TENKV { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }
    }
}
