namespace QLCOFFE.Views
{
    partial class frmLoaiThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiThucDon));
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.labx = new System.Windows.Forms.Label();
            this.labs = new System.Windows.Forms.Label();
            this.cmbTrangThaiLTDon = new System.Windows.Forms.ComboBox();
            this.txtDienGiaiLTDon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenLTDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLTDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grDanhSachKV = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MALH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grQuanLyNV.SuspendLayout();
            this.grDanhSachKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(64, 231);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 39);
            this.btnThemMoi.TabIndex = 109;
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
            this.btnLuu.Location = new System.Drawing.Point(203, 322);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 45);
            this.btnLuu.TabIndex = 112;
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
            this.btnXoa.Location = new System.Drawing.Point(357, 231);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 111;
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
            this.btnSua.Location = new System.Drawing.Point(219, 231);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.labx);
            this.grQuanLyNV.Controls.Add(this.labs);
            this.grQuanLyNV.Controls.Add(this.btnThemMoi);
            this.grQuanLyNV.Controls.Add(this.btnLuu);
            this.grQuanLyNV.Controls.Add(this.cmbTrangThaiLTDon);
            this.grQuanLyNV.Controls.Add(this.btnXoa);
            this.grQuanLyNV.Controls.Add(this.btnSua);
            this.grQuanLyNV.Controls.Add(this.txtDienGiaiLTDon);
            this.grQuanLyNV.Controls.Add(this.label8);
            this.grQuanLyNV.Controls.Add(this.txtTenLTDon);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.txtIdLTDon);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.Location = new System.Drawing.Point(718, 29);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Size = new System.Drawing.Size(464, 406);
            this.grQuanLyNV.TabIndex = 108;
            this.grQuanLyNV.TabStop = false;
            // 
            // labx
            // 
            this.labx.AutoSize = true;
            this.labx.Location = new System.Drawing.Point(200, 142);
            this.labx.Name = "labx";
            this.labx.Size = new System.Drawing.Size(0, 13);
            this.labx.TabIndex = 114;
            // 
            // labs
            // 
            this.labs.AutoSize = true;
            this.labs.Location = new System.Drawing.Point(200, 95);
            this.labs.Name = "labs";
            this.labs.Size = new System.Drawing.Size(0, 13);
            this.labs.TabIndex = 113;
            // 
            // cmbTrangThaiLTDon
            // 
            this.cmbTrangThaiLTDon.FormattingEnabled = true;
            this.cmbTrangThaiLTDon.Location = new System.Drawing.Point(181, 188);
            this.cmbTrangThaiLTDon.Name = "cmbTrangThaiLTDon";
            this.cmbTrangThaiLTDon.Size = new System.Drawing.Size(94, 21);
            this.cmbTrangThaiLTDon.TabIndex = 79;
            this.cmbTrangThaiLTDon.Visible = false;
            // 
            // txtDienGiaiLTDon
            // 
            this.txtDienGiaiLTDon.Location = new System.Drawing.Point(200, 114);
            this.txtDienGiaiLTDon.Name = "txtDienGiaiLTDon";
            this.txtDienGiaiLTDon.Size = new System.Drawing.Size(189, 21);
            this.txtDienGiaiLTDon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Mô tả :";
            // 
            // txtTenLTDon
            // 
            this.txtTenLTDon.Location = new System.Drawing.Point(200, 68);
            this.txtTenLTDon.Name = "txtTenLTDon";
            this.txtTenLTDon.Size = new System.Drawing.Size(189, 21);
            this.txtTenLTDon.TabIndex = 0;
            this.txtTenLTDon.TextChanged += new System.EventHandler(this.txtTenLTDon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên :";
            // 
            // txtIdLTDon
            // 
            this.txtIdLTDon.Enabled = false;
            this.txtIdLTDon.Location = new System.Drawing.Point(200, 17);
            this.txtIdLTDon.Name = "txtIdLTDon";
            this.txtIdLTDon.Size = new System.Drawing.Size(189, 21);
            this.txtIdLTDon.TabIndex = 73;
            this.txtIdLTDon.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Id Loại Thực Đơn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(854, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "QUẢN LÝ  LOẠI THỰC ĐƠN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(209, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "DANH SÁCH LOẠI THỰC ĐƠN";
            // 
            // grDanhSachKV
            // 
            this.grDanhSachKV.Controls.Add(this.gridControl1);
            this.grDanhSachKV.Location = new System.Drawing.Point(-4, 29);
            this.grDanhSachKV.Name = "grDanhSachKV";
            this.grDanhSachKV.Size = new System.Drawing.Size(716, 421);
            this.grDanhSachKV.TabIndex = 107;
            this.grDanhSachKV.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(710, 401);
            this.gridControl1.TabIndex = 88;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MALH,
            this.TENLH,
            this.MOTA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MALH
            // 
            this.MALH.Caption = "MÃ LOẠI HÀNG";
            this.MALH.FieldName = "MALH";
            this.MALH.Image = ((System.Drawing.Image)(resources.GetObject("MALH.Image")));
            this.MALH.Name = "MALH";
            this.MALH.OptionsColumn.ReadOnly = true;
            this.MALH.Visible = true;
            this.MALH.VisibleIndex = 0;
            // 
            // TENLH
            // 
            this.TENLH.Caption = "TÊN LOẠI HÀNG";
            this.TENLH.FieldName = "TENLH";
            this.TENLH.Image = ((System.Drawing.Image)(resources.GetObject("TENLH.Image")));
            this.TENLH.Name = "TENLH";
            this.TENLH.Visible = true;
            this.TENLH.VisibleIndex = 1;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "MÔ TẢ";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.Image = ((System.Drawing.Image)(resources.GetObject("MOTA.Image")));
            this.MOTA.Name = "MOTA";
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            // 
            // frmLoaiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 447);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.grDanhSachKV);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiThucDon";
            this.Text = "LOẠI THỰC ĐƠN";
            this.Load += new System.EventHandler(this.frmLoaiThucDon_Load);
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            this.grDanhSachKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.ComboBox cmbTrangThaiLTDon;
        private System.Windows.Forms.TextBox txtDienGiaiLTDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenLTDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLTDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grDanhSachKV;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MALH;
        private DevExpress.XtraGrid.Columns.GridColumn TENLH;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private System.Windows.Forms.Label labx;
        private System.Windows.Forms.Label labs;
    }
}