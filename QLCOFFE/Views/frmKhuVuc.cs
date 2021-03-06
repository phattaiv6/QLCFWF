using DevExpress.XtraEditors;
using QLCOFFE.BUS;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCOFFE.Views
{
    public partial class frmKhuVuc : Form
    {
        KhuVucBUS KhuVucBUS = new KhuVucBUS();
        public frmKhuVuc()
        {
            InitializeComponent();
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            Loadlist();
            HamTuTang();
        }
        void Loadlist()
        {

            gridControl1.DataSource = new ArenaDAO().FindAll();




        }
        public void HamTuTang()
        {

            int count = KhuVucBUS.DemSLTD();
            count++;
            //string newMANV = string.Format("NV00{0}", ++count);
            txtMaKV.Text = count.ToString();

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {

                Arena arena = new Arena();
                arena.MaKV = txtMaKV.Text;
                arena.TenKV = txtKV.Text;
                arena.TrangThai = "1";



                if (KhuVucBUS.Insert(arena))
                {

                    XtraMessageBox.Show("Thêm thành công", "THÔNG BÁO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKV.Text = "";
                    txtKV.Text = "";


                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                frmKhuVuc_Load(sender, e);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Arena arena = new Arena();

            for (int i = 0; i < gridView1.RowCount; i++)
            {


                arena.MaKV = (gridView1.GetRowCellValue(i, "MAKV").ToString());
                arena.TenKV = gridView1.GetRowCellValue(i, "TENKV").ToString();
              



                KhuVucBUS.Update(arena);



            }


            XtraMessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            frmKhuVuc_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtKV.Text = "";
            txtMaKV.Text = ""; 
        }
    }

}   

