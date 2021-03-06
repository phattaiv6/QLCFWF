using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCOFFE.DTO;
using QLCOFFE.EF;

namespace QLCOFFE.DAO
{
    public class UserDAO
    {
        QuanLyKhachHangDBContext db = new QuanLyKhachHangDBContext();


        // hàm FindAll là hàm lấy ra một danh sách ở dạng list<T>
        public List<KHACHHANG> FindAll()
        {
            return db.KHACHHANGs.ToList();
        }

        public void delete(KHACHHANG p)
        {
            KHACHHANG ph = db.KHACHHANGs.Find(p.MAKH);
            db.KHACHHANGs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm mới nhân viên
        public bool Insert(User user)
        {
            try
            {
                KHACHHANG p = new KHACHHANG
                {
                    MAKH = user.MaKH,
                    TENKH = user.TenKH,
                    DIACHI = user.DiaChi,
                    MALKH = user.MaLKH,
                    TENLKH = user.TenLKH,
                    SDT = user.SDT,
                    DIEMTL = user.DiemTL,
                    TRANGTHAI=user.TrangThai
                    
                };

                db.KHACHHANGs.Add(p);
                db.SaveChanges();
            }
            catch (Exception )
            {
                return false;
            }

            return true;

        }
        public bool Update(User user)
        {


            try
            { //&& u.TRANGTHAI == "1"//
                KHACHHANG p = db.KHACHHANGs.SingleOrDefault(u => u.MAKH == user.MaKH);

                p.MAKH = user.MaKH;
                p.TENKH = user.TenKH;
                p.DIACHI = user.DiaChi;
                p.MALKH = user.MaLKH;
                p.TENLKH = user.TenLKH;
                p.SDT = user.SDT;
                p.DIEMTL = user.DiemTL;
               

                db.SaveChanges();
            }
            catch (Exception )
            {
                return false;
            }

            return true;
        }


        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set => instance = value;
        }
        public UserDAO() { }

        public List<User> LoadList()
        {
            List<User> List = new List<User>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KhachHang where TrangThai=1 ");
            foreach (DataRow item in data.Rows)
            {
                User arena = new User(item);
                List.Add(arena);
            }
            return List;
        }
        public bool Insert(string maKH, string tenKH, string diaChi, string maLKH, string tenLKH, int sDT, int diemTL, string status)
        {
            string query = string.Format("INSERT dbo.KhachHang ( maKH, tenKH,  diaChi,  maLKH, tenLKH, sDT,  diemTL , trangthai ) VALUES  ( N'{0}' , N'{1}', N'{2}', N'{3}', N'{4}', {5}, {6}, {7})", maKH, tenKH, diaChi, maLKH, tenLKH, sDT, diemTL, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdatetDiemTL(string maKH ,int diemTL)
        {
            string query = string.Format("UPDATE dbo.KhachHang SET maKH=N'{0}'  diemTL=N'{6}' ,  WHERE MaKH = {0}", maKH,  diemTL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update(string maKH, string tenKH, string diaChi, string maLKH, string tenLKH, int sDT, int diemTL, string status)
        {
            string query = string.Format("UPDATE dbo.KhachHang SET maKH=N'{0}', tenKH=N'{1}',  diaChi=N'{2}',  maLKH=N'{3}', tenLKH=N'{4}', sDT=N'{5}',  diemTL=N'{6}' , trangthai={7} WHERE MaKH = {0}", maKH, tenKH, diaChi, maLKH, tenLKH, sDT, diemTL, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Delete(string id)
        {
            string query = string.Format("UPDATE dbo.KhachHang SET  Trangthai=0 WHERE MaKH = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public int DemSLKH()
        {
            return db.KHACHHANGs.Count();
        }
        public bool KT(string SDT)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            con.Open();
            bool tatkt = false;
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from KHACHHANG where SDT='" + SDT + "'", con);
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

    }
}
