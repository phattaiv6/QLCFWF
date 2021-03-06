using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QLCOFFE.DAO
{
    public class StaffDAO
    {

        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set => instance = value;
        }
        public StaffDAO() { }

        public List<Staff> LoadSList()
        {
            List<Staff> List = new List<Staff>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NhanVien where TrangThai=1 ");
            foreach (DataRow item in data.Rows)
            {
                Staff arena = new Staff(item);
                List.Add(arena);
            }
            return List;
        }
        public bool Insert(string maNV, string tenNV, string diaChi, string gioiTinh, string chucVu, string tenDN, int sDT, string mK, string trangthai, string thuocTinh)
        {
            string query = string.Format("INSERT dbo.NhanVien (  maNV,  tenNV,  diaChi,  gioiTinh, chucVu,  tendangnhap,    matkhau,sdt,  trangthai, thuocTinh) VALUES  ( N'{0}' , N'{1}' , N'{2}' , N'{3}', N'{4}', N'{5}', N'{6}' , N'{7}', N'{8}', N'{9}')", maNV, tenNV, diaChi, gioiTinh, chucVu, tenDN, mK, sDT, trangthai, thuocTinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update(string maNV, string tenNV, string diaChi, string gioiTinh, string chucVu, string tenDN, int sDT, string mK, string trangthai, string thuocTinh)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET maNV= {0},  tenNV=N'{1}',  diaChi=N'{2}',  gioiTinh=N'{3}' , chucVu=N'{4}' ,  tendangnhap=N'{5}'  ,  matkhau=N'{6}' ,  sDT= N'{7}' ,  trangthai=N'{8}' , thuocTinh=N'{9}' where MaNV= {0}", maNV, tenNV, diaChi, gioiTinh, chucVu, tenDN, mK, sDT, trangthai, thuocTinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Delete(string id)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET  Trangthai=0 WHERE MaNV = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        
        public bool KT(string SDT)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            con.Open();
            bool tatkt = false;
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from NHANVIEN where SDT='" + SDT + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                tatkt = true;
                XtraMessageBox.Show("ĐÃ TỒN TẠI SỐ ĐIỆN THOẠI TRONG HỆ THỐNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            da_kiemtra.Dispose();
            return tatkt;
        }
        public bool KTTK(string DN)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            con.Open();
            bool tatkt = false;
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from NHANVIEN where TENDANGNHAP='" + DN + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);

            if (dt_kiemtra.Rows.Count > 0)
            {
                tatkt = true;
                XtraMessageBox.Show("ĐÃ TỒN TẠI TÊN ĐĂNG NHẬP TRONG HỆ THỐNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            da_kiemtra.Dispose();
            return tatkt;
        }
        //dòng này là tạo mới một DBContext đó là tên mà chúng ta đặt khi tạo bằng entity code first
        QuanLyNhanVienDBContext db = new QuanLyNhanVienDBContext();


        // hàm FindAll là hàm lấy ra một danh sách ở dạng list<T>
        public List<NHANVIEN> FindAll()
        {
            return db.NHANVIEN.ToList();
        }
        //hàm xóa chỉ cần truyền mã nv 
        public void delete(NHANVIEN p)
        {
            NHANVIEN ph = db.NHANVIEN.Find(p.MANV);
            db.NHANVIEN.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm mới nhân viên
        public bool Insert(Staff nhanVien)
        {
            try
            {
                NHANVIEN p = new NHANVIEN
                {
                    MANV = nhanVien.MaNV,
                    TENNV = nhanVien.TenNV,
                    GIOITINH = nhanVien.GioiTinh,
                    CHUCVU = nhanVien.ChucVu,
                    DIACHI = nhanVien.DiaChi,
                    SDT = nhanVien.SDT,
                    TENDANGNHAP = nhanVien.TenDangNhap,
                    MATKHAU = nhanVien.MatKhau,
                    TRANGTHAI = nhanVien.TrangThai,
                };

                db.NHANVIEN.Add(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
        public bool Update(Staff nhanVien)
        {


            try
            { //&& u.TRANGTHAI == "1"//
                NHANVIEN p = db.NHANVIEN.SingleOrDefault(u => u.MANV == nhanVien.MaNV);

                p.MANV = nhanVien.MaNV;
                p.TENNV = nhanVien.TenNV;
                p.GIOITINH = nhanVien.GioiTinh;
                p.CHUCVU = nhanVien.ChucVu;
                p.DIACHI = nhanVien.DiaChi;
                p.SDT = nhanVien.SDT;
                p.TENDANGNHAP = nhanVien.TenDangNhap;
               // p.MATKHAU = nhanVien.MatKhau;

                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }
        public bool Update1(Staff nhanVien)
        {


            try
            { //&& u.TRANGTHAI == "1"//
                NHANVIEN p = db.NHANVIEN.SingleOrDefault(u => u.MANV == nhanVien.MaNV);

                p.MANV = nhanVien.MaNV;
                p.TENNV = nhanVien.TenNV;
                p.GIOITINH = nhanVien.GioiTinh;
                p.CHUCVU = nhanVien.ChucVu;
                p.DIACHI = nhanVien.DiaChi;
                p.SDT = nhanVien.SDT;
                p.TENDANGNHAP = nhanVien.TenDangNhap;
                p.MATKHAU = nhanVien.MatKhau;

                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }


            return true;
        }
        public int DemSLNV()
        {
            return db.NHANVIEN.Count();
        }
    }
}
