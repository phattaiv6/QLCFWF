using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace QLCOFFE.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Istance
        {

            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }

        }

        private AccountDAO() { }


        public bool Login(string us, string pw)
        {
            string query = "Select * From dbo.NHANVIEN where TENDANGNHAP= N'" + us + "' AND MATKHAU= N'" + pw + "'  ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);


            return result.Rows.Count > 0;
        }
        public bool phanquyen(string us)
        {
            string query = "Select chucvu From dbo.NHANVIEN where TENDANGNHAP= N'" + us + "'AND chucvu<> N'Nhân Viên'  ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public bool LoginQR(string manv)
        {
            string query = "Select MANV From dbo.NHANVIEN where MANV= N'" + manv +"'" ;

            DataTable result = DataProvider.Instance.ExecuteQuery(query);


            return result.Rows.Count > 0;
        }
        public bool phanquyenQR(string us)
        {
            string query = "Select chucvu From dbo.NHANVIEN where MANV= N'" + us + "'AND chucvu<> N'Nhân Viên'  ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        internal string LoginQR(System.Windows.Forms.PictureBox pictureBox1)
        {
            throw new NotImplementedException();
        }

        internal string LoginQR(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
