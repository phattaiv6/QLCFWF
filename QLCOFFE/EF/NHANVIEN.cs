namespace QLCOFFE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [StringLength(100)]
        public string MANV { get; set; }

        [StringLength(100)]
        public string TENNV { get; set; }

        [StringLength(100)]
        public string GIOITINH { get; set; }

        [StringLength(20)]
        public string CHUCVU { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        public int? SDT { get; set; }

        [StringLength(100)]
        public string TRANGTHAI { get; set; }

        [StringLength(100)]
        public string TENDANGNHAP { get; set; }

        [StringLength(100)]
        public string MATKHAU { get; set; }

        [StringLength(100)]
        public string THUOCTINH { get; set; }
    }
}
