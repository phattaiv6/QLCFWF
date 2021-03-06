namespace QLCOFFE.Views
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.grDanhSachKH = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnQLMain = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.kHACHHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label10 = new System.Windows.Forms.Label();
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.txtDienThoaiKH = new DevExpress.XtraEditors.TextEdit();
            this.lblF = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblphonex = new System.Windows.Forms.Label();
            this.txtTenLoai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtIKhachHang = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).BeginInit();
            this.grQuanLyNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grDanhSachKH
            // 
            this.grDanhSachKH.Controls.Add(this.gridControl1);
            this.grDanhSachKH.Controls.Add(this.label12);
            this.grDanhSachKH.Location = new System.Drawing.Point(0, 0);
            this.grDanhSachKH.Name = "grDanhSachKH";
            this.grDanhSachKH.Size = new System.Drawing.Size(875, 515);
            this.grDanhSachKH.TabIndex = 72;
            this.grDanhSachKH.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(869, 495);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIACHI,
            this.TENLKH,
            this.SDT,
            this.DIEMTL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "TÌM KIẾM...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MAKH
            // 
            this.MAKH.Caption = "Mã Khách Hàng";
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Image = ((System.Drawing.Image)(resources.GetObject("MAKH.Image")));
            this.MAKH.Name = "MAKH";
            this.MAKH.OptionsColumn.ReadOnly = true;
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 0;
            this.MAKH.Width = 80;
            // 
            // TENKH
            // 
            this.TENKH.Caption = "Tên Khách Hàng";
            this.TENKH.FieldName = "TENKH";
            this.TENKH.Image = ((System.Drawing.Image)(resources.GetObject("TENKH.Image")));
            this.TENKH.Name = "TENKH";
            this.TENKH.Visible = true;
            this.TENKH.VisibleIndex = 1;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Image = ((System.Drawing.Image)(resources.GetObject("DIACHI.Image")));
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 2;
            // 
            // TENLKH
            // 
            this.TENLKH.Caption = "Tên Loại Thẻ";
            this.TENLKH.FieldName = "TENLKH";
            this.TENLKH.Image = ((System.Drawing.Image)(resources.GetObject("TENLKH.Image")));
            this.TENLKH.Name = "TENLKH";
            this.TENLKH.Visible = true;
            this.TENLKH.VisibleIndex = 5;
            this.TENLKH.Width = 105;
            // 
            // SDT
            // 
            this.SDT.Caption = "Số Điện Thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Image = ((System.Drawing.Image)(resources.GetObject("SDT.Image")));
            this.SDT.Name = "SDT";
            this.SDT.OptionsColumn.ReadOnly = true;
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 4;
            // 
            // DIEMTL
            // 
            this.DIEMTL.Caption = "Điểm tích lũy";
            this.DIEMTL.FieldName = "DIEMTL";
            this.DIEMTL.Image = ((System.Drawing.Image)(resources.GetObject("DIEMTL.Image")));
            this.DIEMTL.Name = "DIEMTL";
            this.DIEMTL.Visible = true;
            this.DIEMTL.VisibleIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(262, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 17);
            this.label12.TabIndex = 73;
            this.label12.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(81, 391);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(84, 41);
            this.btnThemMoi.TabIndex = 66;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnQLMain
            // 
            this.btnQLMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMain.Image = ((System.Drawing.Image)(resources.GetObject("btnQLMain.Image")));
            this.btnQLMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMain.Location = new System.Drawing.Point(245, 468);
            this.btnQLMain.Name = "btnQLMain";
            this.btnQLMain.Size = new System.Drawing.Size(116, 39);
            this.btnQLMain.TabIndex = 70;
            this.btnQLMain.Text = "Làm mới";
            this.btnQLMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLMain.UseVisualStyleBackColor = true;
            this.btnQLMain.Click += new System.EventHandler(this.btnQLMain_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(397, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 42);
            this.btnSua.TabIndex = 67;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(251, 391);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 44);
            this.btnXoa.TabIndex = 68;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // kHACHHANGBindingSource1
            // 
            this.kHACHHANGBindingSource1.DataMember = "KHACHHANG";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(965, 260);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "CHỨC NĂNG ";
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.txtDienThoaiKH);
            this.grQuanLyNV.Controls.Add(this.lblF);
            this.grQuanLyNV.Controls.Add(this.lblT);
            this.grQuanLyNV.Controls.Add(this.lblphonex);
            this.grQuanLyNV.Controls.Add(this.label10);
            this.grQuanLyNV.Controls.Add(this.txtTenLoai);
            this.grQuanLyNV.Controls.Add(this.btnQLMain);
            this.grQuanLyNV.Controls.Add(this.btnThemMoi);
            this.grQuanLyNV.Controls.Add(this.btnSua);
            this.grQuanLyNV.Controls.Add(this.txtIKhachHang);
            this.grQuanLyNV.Controls.Add(this.btnXoa);
            this.grQuanLyNV.Controls.Add(this.txtTT);
            this.grQuanLyNV.Controls.Add(this.txtDiem);
            this.grQuanLyNV.Controls.Add(this.label5);
            this.grQuanLyNV.Controls.Add(this.label4);
            this.grQuanLyNV.Controls.Add(this.label1);
            this.grQuanLyNV.Controls.Add(this.txtMaLoai);
            this.grQuanLyNV.Controls.Add(this.txtDiaChiKH);
            this.grQuanLyNV.Controls.Add(this.label9);
            this.grQuanLyNV.Controls.Add(this.label8);
            this.grQuanLyNV.Controls.Add(this.txtTenKH);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.grQuanLyNV.Location = new System.Drawing.Point(875, 0);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Size = new System.Drawing.Size(495, 635);
            this.grQuanLyNV.TabIndex = 90;
            this.grQuanLyNV.TabStop = false;
            // 
            // txtDienThoaiKH
            // 
            this.txtDienThoaiKH.Location = new System.Drawing.Point(98, 114);
            this.txtDienThoaiKH.Name = "txtDienThoaiKH";
            this.txtDienThoaiKH.Size = new System.Drawing.Size(553, 20);
            this.txtDienThoaiKH.TabIndex = 93;
            this.txtDienThoaiKH.EditValueChanged += new System.EventHandler(this.txtDienThoaiKH_EditValueChanged);
            this.txtDienThoaiKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoaiKH_KeyPress);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(98, 139);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(0, 13);
            this.lblF.TabIndex = 92;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(98, 139);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 13);
            this.lblT.TabIndex = 91;
            // 
            // lblphonex
            // 
            this.lblphonex.AutoSize = true;
            this.lblphonex.Location = new System.Drawing.Point(57, 108);
            this.lblphonex.Name = "lblphonex";
            this.lblphonex.Size = new System.Drawing.Size(0, 13);
            this.lblphonex.TabIndex = 90;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.EditValue = "Bạc";
            this.txtTenLoai.Location = new System.Drawing.Point(100, 196);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTenLoai.Properties.Items.AddRange(new object[] {
            "BẠC",
            "VÀNG",
            "BẠCH KIM",
            "KIM CƯƠNG"});
            this.txtTenLoai.Size = new System.Drawing.Size(372, 20);
            this.txtTenLoai.TabIndex = 89;
            // 
            // txtIKhachHang
            // 
            this.txtIKhachHang.Enabled = false;
            this.txtIKhachHang.Location = new System.Drawing.Point(99, 32);
            this.txtIKhachHang.Name = "txtIKhachHang";
            this.txtIKhachHang.Size = new System.Drawing.Size(808, 21);
            this.txtIKhachHang.TabIndex = 88;
            // 
            // txtTT
            // 
            this.txtTT.Enabled = false;
            this.txtTT.Location = new System.Drawing.Point(99, 273);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(808, 21);
            this.txtTT.TabIndex = 86;
            this.txtTT.Visible = false;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(100, 233);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(808, 21);
            this.txtDiem.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Tên Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(99, 273);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(553, 21);
            this.txtMaLoai.TabIndex = 80;
            this.txtMaLoai.Visible = false;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(100, 158);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(809, 21);
            this.txtDiaChiKH.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Điện thoại:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(98, 72);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(809, 21);
            this.txtTenKH.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Id Khách Hàng :";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 635);
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grDanhSachKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.grDanhSachKH.ResumeLayout(false);
            this.grDanhSachKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).EndInit();
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grDanhSachKH;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnQLMain;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
       // private QUANLYCF1DataSet1 qUANLYCF1DataSet1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
       // private QUANLYCF1DataSet2 qUANLYCF1DataSet2;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource1;
      //  private QUANLYCF1DataSet2TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter1;
     //   private QUANLYCF1DataSet3 qUANLYCF1DataSet3;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DevExpress.XtraGrid.Columns.GridColumn TENKH;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn TENLKH;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMTL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.Label lblphonex;
        private DevExpress.XtraEditors.ComboBoxEdit txtTenLoai;
        private System.Windows.Forms.TextBox txtIKhachHang;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblT;
        private DevExpress.XtraEditors.TextEdit txtDienThoaiKH;
    }
}