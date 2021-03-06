using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class Bill
    {
        public Bill(int maHDBH, string maNV, int maBan, string maKH, string trangThai, int giaSP, DateTime? thoiGian, int giamGia = 0)
        {
            this.MaHDBH = maHDBH;
            this.MaNV = maNV;
            this.MaBan = maBan;
            this.MaKH = maKH;
            this.TrangThai = trangThai;
            this.GiaSP = giaSP;
            this.ThoiGian = thoiGian;
            this.GiamGia = giamGia;

        }
        public Bill(DataRow row)
        {
            this.MaHDBH = (int)row["MaHDBH"];
            this.MaNV = row["MaNV"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.MaBan = (int)row["MaBan"];
            this.GiaSP = (int)row["GiaSP"];
            this.GiamGia = (int)row["GiamGia"];
            this.ThoiGian = (DateTime?)row["ThoiGian"];
            var dateCheck = row["ThoiGian"];

        }
        private int maHDBH;
        private string maNV;
        private int maBan;
        private string maKH;
        private string trangThai;
        private int giaSP;
        private DateTime? thoiGian;
        private int giamGia;
        public int MaHDBH { get => maHDBH; set => maHDBH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int GiaSP { get => giaSP; set => giaSP = value; }
        public DateTime? ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
    }
}
