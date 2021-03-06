using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class BillInfo
    {


        public BillInfo(int maHDBH, int maHH, string trangThai, int soLuong, int giaBan)
        {
            this.MaHDBH = maHDBH;
            this.MaHH = maHH;
            this.TrangThai = trangThai;
            this.SoLuong = soLuong;
            this.GiaBan = giaBan;

        }
        public BillInfo(DataRow row)
        {
            this.MaHDBH = (int)row["MaHDBH"];
            this.MaHH = (int)row["MaHH"];
            this.TrangThai = row["TrangThai"].ToString();
            this.GiaBan = (int)row["GiaBan"];
            this.SoLuong = (int)row["SoLuong"];

        }
        private int maHDBH;
        private int maHH;
        private string trangThai;
        private int giaBan;
        private int soLuong;

        public int MaHDBH { get => maHDBH; set => maHDBH = value; }
        public int MaHH { get => maHH; set => maHH = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
