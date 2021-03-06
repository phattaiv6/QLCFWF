namespace QLCOFFE.Views
{
    partial class FrmBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBan));
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cmbTenKhuVuc = new System.Windows.Forms.ComboBox();
            this.cmbTrangThaiBan = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.labx = new System.Windows.Forms.Label();
            this.labs = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.txtTenBan = new DevExpress.XtraEditors.TextEdit();
            this.txtIdBan = new System.Windows.Forms.TextBox();
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grThongTinBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBan.Properties)).BeginInit();
            this.grDanhSachBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 105;
            this.label4.Text = "THÔNG TIN BÀN";
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(284, 389);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 35);
            this.btnHuy.TabIndex = 113;
            this.btnHuy.Text = "Làm mới";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(412, 298);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 36);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbTenKhuVuc
            // 
            this.cmbTenKhuVuc.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTenKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKhuVuc.FormattingEnabled = true;
            this.cmbTenKhuVuc.Location = new System.Drawing.Point(246, 152);
            this.cmbTenKhuVuc.Name = "cmbTenKhuVuc";
            this.cmbTenKhuVuc.Size = new System.Drawing.Size(231, 23);
            this.cmbTenKhuVuc.TabIndex = 97;
            this.cmbTenKhuVuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTenKhuVuc_KeyDown);
            // 
            // cmbTrangThaiBan
            // 
            this.cmbTrangThaiBan.FormattingEnabled = true;
            this.cmbTrangThaiBan.Items.AddRange(new object[] {
            "Bàn Trống",
            "Có Người"});
            this.cmbTrangThaiBan.Location = new System.Drawing.Point(293, 231);
            this.cmbTrangThaiBan.Name = "cmbTrangThaiBan";
            this.cmbTrangThaiBan.Size = new System.Drawing.Size(109, 23);
            this.cmbTrangThaiBan.TabIndex = 96;
            this.cmbTrangThaiBan.Visible = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(163, 298);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(93, 36);
            this.btnThemMoi.TabIndex = 109;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên Bàn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tên Khu Vực :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 92;
            this.label6.Text = "Id Bàn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "DANH SÁCH BÀN";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(293, 298);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 36);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.Controls.Add(this.labx);
            this.grThongTinBan.Controls.Add(this.labs);
            this.grThongTinBan.Controls.Add(this.lbla);
            this.grThongTinBan.Controls.Add(this.txtTenBan);
            this.grThongTinBan.Controls.Add(this.label4);
            this.grThongTinBan.Controls.Add(this.cmbTenKhuVuc);
            this.grThongTinBan.Controls.Add(this.btnHuy);
            this.grThongTinBan.Controls.Add(this.cmbTrangThaiBan);
            this.grThongTinBan.Controls.Add(this.btnSua);
            this.grThongTinBan.Controls.Add(this.btnXoa);
            this.grThongTinBan.Controls.Add(this.btnThemMoi);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.txtIdBan);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.Location = new System.Drawing.Point(816, 12);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Size = new System.Drawing.Size(574, 487);
            this.grThongTinBan.TabIndex = 108;
            this.grThongTinBan.TabStop = false;
            // 
            // labx
            // 
            this.labx.AutoSize = true;
            this.labx.Location = new System.Drawing.Point(245, 224);
            this.labx.Name = "labx";
            this.labx.Size = new System.Drawing.Size(0, 15);
            this.labx.TabIndex = 117;
            // 
            // labs
            // 
            this.labs.AutoSize = true;
            this.labs.Location = new System.Drawing.Point(245, 178);
            this.labs.Name = "labs";
            this.labs.Size = new System.Drawing.Size(0, 15);
            this.labs.TabIndex = 116;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(254, 214);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(0, 15);
            this.lbla.TabIndex = 115;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(246, 201);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(231, 20);
            this.txtTenBan.TabIndex = 114;
            this.txtTenBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenBan_KeyDown);
            // 
            // txtIdBan
            // 
            this.txtIdBan.Enabled = false;
            this.txtIdBan.Location = new System.Drawing.Point(246, 96);
            this.txtIdBan.Name = "txtIdBan";
            this.txtIdBan.Size = new System.Drawing.Size(231, 22);
            this.txtIdBan.TabIndex = 93;
            this.txtIdBan.TabStop = false;
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.Controls.Add(this.label1);
            this.grDanhSachBan.Controls.Add(this.gridControl1);
            this.grDanhSachBan.Location = new System.Drawing.Point(0, 0);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Size = new System.Drawing.Size(810, 502);
            this.grDanhSachBan.TabIndex = 107;
            this.grDanhSachBan.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(804, 482);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENBAN,
            this.MAKV,
            this.MABAN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // TENBAN
            // 
            this.TENBAN.Caption = "TÊN BÀN";
            this.TENBAN.FieldName = "TENBAN";
            this.TENBAN.Image = ((System.Drawing.Image)(resources.GetObject("TENBAN.Image")));
            this.TENBAN.Name = "TENBAN";
            this.TENBAN.Visible = true;
            this.TENBAN.VisibleIndex = 1;
            // 
            // MAKV
            // 
            this.MAKV.Caption = "MÃ KHU VỰC";
            this.MAKV.FieldName = "MAKV";
            this.MAKV.Image = ((System.Drawing.Image)(resources.GetObject("MAKV.Image")));
            this.MAKV.Name = "MAKV";
            this.MAKV.Visible = true;
            this.MAKV.VisibleIndex = 2;
            // 
            // MABAN
            // 
            this.MABAN.Caption = "MÃ BÀN";
            this.MABAN.FieldName = "MABAN";
            this.MABAN.Image = ((System.Drawing.Image)(resources.GetObject("MABAN.Image")));
            this.MABAN.Name = "MABAN";
            this.MABAN.OptionsColumn.ReadOnly = true;
            this.MABAN.Visible = true;
            this.MABAN.VisibleIndex = 0;
            // 
            // FrmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 514);
            this.Controls.Add(this.grThongTinBan);
            this.Controls.Add(this.grDanhSachBan);
            this.Name = "FrmBan";
            this.Text = "BÀN";
            this.Load += new System.EventHandler(this.FrmBan_Load);
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBan.Properties)).EndInit();
            this.grDanhSachBan.ResumeLayout(false);
            this.grDanhSachBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbTenKhuVuc;
        private System.Windows.Forms.ComboBox cmbTrangThaiBan;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.TextBox txtIdBan;
        private System.Windows.Forms.GroupBox grDanhSachBan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TENBAN;
        private DevExpress.XtraGrid.Columns.GridColumn MAKV;
        private DevExpress.XtraGrid.Columns.GridColumn MABAN;
        private DevExpress.XtraEditors.TextEdit txtTenBan;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label labs;
        private System.Windows.Forms.Label labx;
    }
}