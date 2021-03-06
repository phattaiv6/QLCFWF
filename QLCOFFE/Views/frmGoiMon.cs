using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCOFFE.DAO;
using QLCOFFE.BUS;

using QLCOFFE.EF;
using DevExpress.XtraEditors;
using QLCOFFE.DTO;
using System.Globalization;

namespace QLCOFFE.Views
{
    public partial class frmGoiMon : Form
    {
        public frmGoiMon()
        {
            InitializeComponent();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lstmonan.Tag as Table;

                // int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
                int idBill = gm.GetUncheckBillIDByTableID(table.MaBan);
                int maHH = (cbTenMon.SelectedItem as Food).MaHH;
                int soLuong = (int)nmSoLuong.Value;

                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.MaBan);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), maHH, soLuong, "0", 0);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, maHH, soLuong, "0", 0);
                }
                LoadTable();
                ShowBill(table.MaBan);
            }
            catch { XtraMessageBox.Show("Bạn chưa chọn bàn!"); }
        }
        GoiMonBUS gm = new GoiMonBUS();

        void LoadTable()
        {
            string MaKV1 = cba.Text;
            flTable.Controls.Clear();
            //List<Table> tableList = TableDAO.Instance.LoadTableList();
            List<Table> tableList = TableDAO.Instance.LoadTableListA(MaKV1);
            foreach (Table item in tableList)
            {
                
                Button btn = new Button() { Width = TableDAO.Width, Height = TableDAO.Height };
                btn.Focus();
                btn.Text = item.TenBAn + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                
                switch (item.TrangThai)
                {
                    case "Bàn Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.Yellow;
                        break;
                    case "Bàn Hư":
                        btn.BackColor = Color.Red;
                        break;

                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flTable.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {

            int tableID = ((sender as Button).Tag as Table).MaBan;
            lstmonan.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        void ShowBill(int MaBan)
        {

            lstmonan.Items.Clear();
            //List<QLCOFFE.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(MaBan);
            List<MenuFood> listBillInfo = gm.GetListMenuByTable(MaBan);
            int tongTien = 0;
            foreach (MenuFood item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenHH.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.GiaBan.ToString());
                lsvItem.SubItems.Add(item.GiaSP.ToString());
                tongTien += item.GiaSP;
                lstmonan.Items.Add(lsvItem);
            }
            CultureInfo c = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = c;"c",c
            txtTongTien.Text = tongTien.ToString();
        }
        void LoadLoaiSP()
        {
            //List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            List<Category> listCategory = gm.GetListCategory();
            //GoiMonBUS.LoadLoaiSP();
            cbLoaiMon.DataSource = listCategory;
            cbLoaiMon.DisplayMember = "TenLH";
        }
        void LoadSPByLoaiSP(int id)
        {
            // List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            List<Food> listFood = gm.GetFoodByCategoryID(id);
            cbTenMon.DataSource = listFood;
            cbTenMon.DisplayMember = "TenHH";
        }

        private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            //int idc = Convert.ToInt32(id);
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.MaLH;

            LoadSPByLoaiSP(id);
        }
        void loadcontrol(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = ArenaDAO.Instance.LoadArenaList();
            cb.DisplayMember = "maKV";

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lstmonan.Tag as Table;
                int giamGia = (int)nmGiamGia.Value;
                int maBan = gm.GetUncheckBillIDByTableID(table.MaBan);
                string moTa = cmbMT.Text;
                double tongTien = Convert.ToDouble(txtTongTien.Text);
                double ftt = tongTien - (tongTien / 100) * giamGia;
                int a = Convert.ToInt32(ftt);
                if (maBan != -1)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n Tổng tiền= {1} - ({1} / 100) x {2}% = {3} VND ", table.TenBAn, tongTien, giamGia, a), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(maBan, giamGia, a,moTa);
                        ShowBill(table.MaBan);

                        LoadTable();
                    }
                }
                else
                { XtraMessageBox.Show("HÃY CHỌN BÀN CÓ NGƯỜI ĐỂ THANH TOÁN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch { XtraMessageBox.Show("CÓ LỖI KHI THAO TÁC", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            LoadTable(); LoadLoaiSP();
            LoadComboboxTable(cbChuyenBan);
            loadcontrol(cba);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {

            int id1 = (lstmonan.Tag as Table).MaBan;

            int id2 = (cbChuyenBan.SelectedItem as Table).MaBan;

            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lstmonan.Tag as Table).TenBAn, (cbChuyenBan.SelectedItem as Table).TenBAn), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();

            }
        }
        void LoadComboboxTable(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "TenBan";
        }

        private void cba_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void cbChuyenBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
