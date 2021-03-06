using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCOFFE.DAO;
using QLCOFFE.Views;
using System.Security.Cryptography;


namespace QLCOFFE
{
    
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        // public static string userName = "a";
    
        public frmDangNhap()
        {
            InitializeComponent();
        }
        bool Login(string us, string pw)
        {
            return AccountDAO.Istance.Login(us, pw);
        }
        public static string userName1 ;
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            string userName = txtTenDangNhap.Text;
            userName1 = userName;
            string passWork = MD5Hash(txtMatKhau.Text);
           
            if (Login(userName, passWork) == true && passWork != "'or 1=1--")
            {

                if (AccountDAO.Istance.phanquyen(txtTenDangNhap.Text))
                {


                    frmMain v = new frmMain();
                    v.a = txtTenDangNhap.ToString();
                    this.Hide();
                    v.ShowDialog();
                    this.Close();
                }
                else
                {

                    frmMain frm = new frmMain(); frm.a = "";
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            if (Login(userName, passWork) == false)
            {

                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");

                if (txtTenDangNhap.Text == "")
                {
                    XtraMessageBox.Show("Tên đăng nhập trống");
                }
                else if (txtTenDangNhap.Text != "")
                {
                    if (txtMatKhau.Text == "")
                        XtraMessageBox.Show("Mật khẩu trống");
                }



            }

        }
        

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btncmr_Click(object sender, EventArgs e)
        {
           frmDangNhapQRcode frm = new frmDangNhapQRcode(); 
            this.Hide();
            frm.ShowDialog();
            this.Close();
            
        }
    }
}