using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace QLCOFFE.Views
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1()
        {
            InitializeComponent();
        }

        public DataTable DataSouce { get; internal set; }
    }
}
