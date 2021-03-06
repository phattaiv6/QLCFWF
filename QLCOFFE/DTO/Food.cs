using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class Food
    {
        public Food(int maHH, string tenHH, int maLH, string trangThai, int giaSP)
        {
            this.MaHH = maHH;
            this.MaLH = maLH;
            this.TenHH = tenHH;
            this.GiaSP = giaSP;
            this.TrangThai = trangThai;
        }
        public Food(DataRow row)
        {
            this.MaHH = (int)row["MaHH"];
            this.TenHH = row["TenHH"].ToString();
            this.MaLH = (int)row["MaLH"];
            this.GiaSP = (int)row["GiaSP"];
            this.TrangThai = row["TrangThai"].ToString();
        }
        private int maHH;
        private string tenHH;
        private int maLH;
        private int giaSP;
        private string trangThai;

        public int MaHH { get => maHH; set => maHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public int MaLH { get => maLH; set => maLH = value; }
        public int GiaSP { get => giaSP; set => giaSP = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
