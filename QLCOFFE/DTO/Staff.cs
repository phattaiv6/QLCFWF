using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class Staff
    {

        public Staff(string maNV, string tenNV, string gioiTinh, string chucVu, string diaChi, int sDT,  string tenDangNhap, string matKhau , string trangThai)
        {

            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.GioiTinh = gioiTinh;
            this.ChucVu = chucVu;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.TrangThai = trangThai;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            //this.ThuocTinh = thuocTinh;
        }
        public Staff(DataRow row)
        {
            this.MaNV = row["maNV"].ToString();
            this.TenNV = row["tenNV"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.ChucVu = row["chucVu"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.SDT = (int)row["sdt"];
            this.TrangThai = row["TrangThai"].ToString();
            this.TenDangNhap = row["tendangnhap"].ToString();
            this.MatKhau = row["matkhau"].ToString();
           // this.ThuocTinh = row["thuoctinh"].ToString();
        }

        public Staff ()
        {

        }

        private string maNV;
        private string tenNV;
        private string gioiTinh;
        private string chucVu;
        private string diaChi;
        private int sDT;
        private string trangThai;
        private string tenDangNhap;
        private string matKhau;
        //private string thuocTinh;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SDT { get => sDT; set => sDT = value; }
       public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
     //   public string ThuocTinh { get => thuocTinh; set => thuocTinh = value; }
    }

}
