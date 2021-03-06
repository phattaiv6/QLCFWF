namespace QLCOFFE.Views
{
    partial class frmDanhSachTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachTD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MALH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIASP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grThongtinTD = new System.Windows.Forms.GroupBox();
            this.labgia = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.cmGia = new System.Windows.Forms.NumericUpDown();
            this.cmbTenLTD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grThongtinTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 450);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 419);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHH,
            this.TENHH,
            this.MALH,
            this.GIASP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MAHH
            // 
            this.MAHH.Caption = "MÃ HÀNG HÓA";
            this.MAHH.FieldName = "MAHH";
            this.MAHH.Image = ((System.Drawing.Image)(resources.GetObject("MAHH.Image")));
            this.MAHH.Name = "MAHH";
            this.MAHH.Visible = true;
            this.MAHH.VisibleIndex = 0;
            // 
            // TENHH
            // 
            this.TENHH.Caption = "TÊN HÀNG HÓA";
            this.TENHH.FieldName = "TENHH";
            this.TENHH.Image = ((System.Drawing.Image)(resources.GetObject("TENHH.Image")));
            this.TENHH.Name = "TENHH";
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            // 
            // MALH
            // 
            this.MALH.Caption = "MÃ LOẠI HÀNG";
            this.MALH.FieldName = "MALH";
            this.MALH.Image = ((System.Drawing.Image)(resources.GetObject("MALH.Image")));
            this.MALH.Name = "MALH";
            this.MALH.Visible = true;
            this.MALH.VisibleIndex = 2;
            // 
            // GIASP
            // 
            this.GIASP.Caption = "GIÁ SẢN PHẨM";
            this.GIASP.FieldName = "GIASP";
            this.GIASP.Image = ((System.Drawing.Image)(resources.GetObject("GIASP.Image")));
            this.GIASP.Name = "GIASP";
            this.GIASP.Visible = true;
            this.GIASP.VisibleIndex = 3;
            // 
            // grThongtinTD
            // 
            this.grThongtinTD.Controls.Add(this.labgia);
            this.grThongtinTD.Controls.Add(this.labelx);
            this.grThongtinTD.Controls.Add(this.btnThemMoi);
            this.grThongtinTD.Controls.Add(this.btnLuu);
            this.grThongtinTD.Controls.Add(this.btnXoa);
            this.grThongtinTD.Controls.Add(this.btnSua);
            this.grThongtinTD.Controls.Add(this.txtTT);
            this.grThongtinTD.Controls.Add(this.cmGia);
            this.grThongtinTD.Controls.Add(this.cmbTenLTD);
            this.grThongtinTD.Controls.Add(this.label7);
            this.grThongtinTD.Controls.Add(this.txtTenTD);
            this.grThongtinTD.Controls.Add(this.label4);
            this.grThongtinTD.Controls.Add(this.label3);
            this.grThongtinTD.Controls.Add(this.txtIdTD);
            this.grThongtinTD.Controls.Add(this.label2);
            this.grThongtinTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grThongtinTD.Location = new System.Drawing.Point(757, 0);
            this.grThongtinTD.Name = "grThongtinTD";
            this.grThongtinTD.Size = new System.Drawing.Size(432, 450);
            this.grThongtinTD.TabIndex = 1;
            this.grThongtinTD.TabStop = false;
            // 
            // labgia
            // 
            this.labgia.AutoSize = true;
            this.labgia.Location = new System.Drawing.Point(204, 231);
            this.labgia.Name = "labgia";
            this.labgia.Size = new System.Drawing.Size(0, 13);
            this.labgia.TabIndex = 99;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(202, 163);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(0, 13);
            this.labelx.TabIndex = 98;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(63, 299);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(84, 35);
            this.btnThemMoi.TabIndex = 94;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(196, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 42);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "LÀM MỚI";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(326, 299);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 35);
            this.btnXoa.TabIndex = 96;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(207, 299);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 37);
            this.btnSua.TabIndex = 95;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(202, 256);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(100, 20);
            this.txtTT.TabIndex = 93;
            this.txtTT.Visible = false;
            // 
            // cmGia
            // 
            this.cmGia.Location = new System.Drawing.Point(207, 197);
            this.cmGia.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.cmGia.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cmGia.Name = "cmGia";
            this.cmGia.Size = new System.Drawing.Size(120, 20);
            this.cmGia.TabIndex = 92;
            this.cmGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbTenLTD
            // 
            this.cmbTenLTD.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTenLTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLTD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTenLTD.FormattingEnabled = true;
            this.cmbTenLTD.Location = new System.Drawing.Point(207, 81);
            this.cmbTenLTD.Name = "cmbTenLTD";
            this.cmbTenLTD.Size = new System.Drawing.Size(100, 21);
            this.cmbTenLTD.TabIndex = 76;
            this.cmbTenLTD.SelectedIndexChanged += new System.EventHandler(this.cmbTenLTD_SelectedIndexChanged);
            this.cmbTenLTD.TextChanged += new System.EventHandler(this.cmbTenLTD_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Đơn Giá  :";
            // 
            // txtTenTD
            // 
            this.txtTenTD.Location = new System.Drawing.Point(207, 136);
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(100, 20);
            this.txtTenTD.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Tên Thực Đơn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tên Loại Thực Đơn :";
            // 
            // txtIdTD
            // 
            this.txtIdTD.Enabled = false;
            this.txtIdTD.Location = new System.Drawing.Point(207, 32);
            this.txtIdTD.Name = "txtIdTD";
            this.txtIdTD.Size = new System.Drawing.Size(100, 20);
            this.txtIdTD.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Id Thực Đơn :";
            // 
            // frmDanhSachTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.grThongtinTD);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhSachTD";
            this.Text = "DANH SÁCH THỰC ĐƠN";
            this.Load += new System.EventHandler(this.frmDanhSachTD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grThongtinTD.ResumeLayout(false);
            this.grThongtinTD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn MALH;
        private DevExpress.XtraGrid.Columns.GridColumn GIASP;
        private System.Windows.Forms.GroupBox grThongtinTD;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.NumericUpDown cmGia;
        private System.Windows.Forms.ComboBox cmbTenLTD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labgia;
    }
}