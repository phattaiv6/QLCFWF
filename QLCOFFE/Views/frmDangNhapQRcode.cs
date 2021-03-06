using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using QLCOFFE.DAO;
using ZXing;
using ZXing.QrCode;
namespace QLCOFFE.Views
{
    public partial class frmDangNhapQRcode : Form
    {
        public frmDangNhapQRcode()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
       

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }
        private void DangNhapQRcode_Load(object sender, EventArgs e) //load tất cả các thiết bị camera vào combox
        { 
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbCMR.Items.Add(Device.Name);
            }
            cmbCMR.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        { //để bắt đầu sử dụng camera
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbCMR.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btnWebcam.Enabled = false;
            
            timer1.Start();
            
            txtMANV.Text = "";
        }

      

        private void timer1_Tick(object sender, EventArgs e) //kiểm tra 
        {
            BarcodeReader Reader = new BarcodeReader();

            try
            {
                string manv;
                manv = txtMANV.Text;
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                string decoded = result.ToString().Trim();
                txtMANV.Text = decoded;

                if (AccountDAO.Istance.LoginQR(manv) == true)
                {
                    FinalFrame.Stop();
                    timer1.Stop();
                    if (AccountDAO.Istance.LoginQR(txtMANV.Text))
                    {


                        if (AccountDAO.Istance.phanquyenQR(txtMANV.Text))
                        {


                            frmMain frm = new frmMain();
                            frm.a = txtMANV.ToString();
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {

                            frmMain frm = new frmMain();
                            frm.a = "";
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }

                    }
                    else 
                    {
                        //MessageBox.Show("Mã QR không có trong hệ thống");
                    }

              
                }
                
              

            }
            catch (Exception ex)
            {
               
            }
        }

        private void DangNhapQRcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
            timer1.Stop();
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }



















        //public string textcode
        //{
        //    get { return this.txtMANV.Text; }
        //    set { this.txtMANV.Text = value; }
        //}
    }
}























