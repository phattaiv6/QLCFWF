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
using DevExpress.XtraReports.UI;

namespace QLCOFFE.Views
{
    public partial class Report : DevExpress.XtraEditors.XtraForm
    {
        public Report()
        {
            InitializeComponent();
        }

        public object DataSouce { get; internal set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           BillDAO.Instance.CreateReport();
           
        }
    }
}