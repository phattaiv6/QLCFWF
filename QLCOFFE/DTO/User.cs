using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using QLCOFFE.BUS;
namespace QLCOFFE.DTO
{
    public class User
    {

        public User(string maKH, string tenKH, string diaChi, string maLKH, string tenLKH, int sDT, int diemTL,string trangThai)
        {

            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
            this.MaLKH = maLKH;
            this.TenLKH = tenLKH;
            this.TrangThai = trangThai;
            this.SDT = sDT;
            this.DiemTL = diemTL;
            
        }
        public User(DataRow row)
        {
            this.MaKH = row["Makh"].ToString();
            this.TenKH = row["tenkh"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.MaLKH = row["Malkh"].ToString();
            this.TenLKH = row["tenlkh"].ToString();
           this.TrangThai = row["trangthai"].ToString();
            this.DiemTL = (int)row["diemtl"];
            this.SDT = (int)row["sdt"];
        }

        public User()
        {
        }

        private string maKH;
        private string tenKH;
        private string diaChi;
        private string maLKH;
        private string tenLKH;
      private string trangThai;
        private int sDT;
        private int diemTL;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaLKH { get => maLKH; set => maLKH = value; }
        public string TenLKH { get => tenLKH; set => tenLKH = value; }
       public string TrangThai { get => trangThai; set => trangThai = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public int DiemTL { get => diemTL; set => diemTL = value; }
    }
}
