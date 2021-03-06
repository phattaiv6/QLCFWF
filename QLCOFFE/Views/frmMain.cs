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

namespace QLCOFFE.Views
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public  string a;
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienTen();
            if (a == "")
            {

                btnNhanVien.Dispose();
                btn_khachhang.Dispose();
                btnBan.Dispose();
                btnThucDon.Dispose();
                btnDSTD.Dispose();
                btnDSHD.Dispose();
                btnNhanSu.Dispose();
                btnKhuVuc.Dispose();
            }
        }
        void HienTen()
        {
            lblname1.Text = frmDangNhap.userName1;
        }
        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmNhanVien();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lên



        }

        private void btn_khachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmKhachHang();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lên
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnThucDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmLoaiThucDon();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }

        private void btnBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new FrmBan();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }

        private void btnDSTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmDanhSachTD();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }

        private void btnGoiMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmGoiMon();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmDanhSachHD();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new Report();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
            

        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmQLTK();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }

        private void btnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tam = new frmKhuVuc();//tạo khai báo frmthemchucvula form bạn cần show ra
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == tam.Name)//kiểm tra tồn
                    {
                        child.Activate();//active
                        child.Activate();

                        return;//trả về
                    }
                }
            }

            tam.MdiParent = this;//nếu chưa tồn thì gọi nó ra
            tam.Show();//hiển thị lê
        }
    }

}