using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using System.Windows.Forms;

namespace QLCOFFE.Views
{
    public partial class frmDanhSachHD : Form
    {
        public frmDanhSachHD()
        {
            InitializeComponent();
        }

        private void frmDanhSachHD_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        void LoadList()
        {
            gridControl1.DataSource = new BillDAO().FindAll();
        }
      
    }
}
