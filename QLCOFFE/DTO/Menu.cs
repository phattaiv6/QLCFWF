using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class MenuFood
    {
        public MenuFood(string tenHH, int soLuong, int giaBan, int giaSP , int maHH , string trangThai ,int maLH)
        {
            this.TenHH = tenHH;
            this.SoLuong = soLuong;
            this.GiaBan = giaBan;
            this.GiaSP = giaSP;
            this.MaHH = maHH;
            this.TrangThai = trangThai;
            this.MaLH = maLH;
        }
        public MenuFood(DataRow row)
        {
            this.TenHH = row["tenHH"].ToString();
            this.GiaBan = (int)row["GiaSP"];
            this.SoLuong = (int)row["SoLuong"];
            this.GiaSP = (int)row["totalPrice"];
           // this.MaHH = (int)row["maHH"];
            //this.TrangThai = row["trangThai"].ToString();
            //this.MaLH = (int)row["maLH"];
        }
        public MenuFood()
        {

        }
        private string tenHH;
        private int soLuong;
        private int giaSP;
        private int giaBan;
        private int maHH;
        private string trangThai;
        private int maLH;
        public string TenHH { get => tenHH; set => tenHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaSP { get => giaSP; set => giaSP = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int MaHH { get => maHH; set => maHH = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int MaLH { get => maLH; set => maLH = value; }
    }
}
