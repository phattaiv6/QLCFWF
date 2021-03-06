namespace QLCOFFE.Views
{
    partial class frmDanhSachHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachHD));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHDBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(884, 491);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHDBH,
            this.MABAN,
            this.TONGTIEN,
            this.THOIGIAN,
            this.GIAMGIA,
            this.MOTA});
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
            // MAHDBH
            // 
            this.MAHDBH.Caption = "MÃ HÓA ĐƠN";
            this.MAHDBH.FieldName = "MAHDBH";
            this.MAHDBH.Image = ((System.Drawing.Image)(resources.GetObject("MAHDBH.Image")));
            this.MAHDBH.Name = "MAHDBH";
            this.MAHDBH.OptionsColumn.ReadOnly = true;
            this.MAHDBH.Visible = true;
            this.MAHDBH.VisibleIndex = 0;
            // 
            // MABAN
            // 
            this.MABAN.Caption = "MÃ BÀN";
            this.MABAN.FieldName = "MABAN";
            this.MABAN.Image = ((System.Drawing.Image)(resources.GetObject("MABAN.Image")));
            this.MABAN.Name = "MABAN";
            this.MABAN.OptionsColumn.ReadOnly = true;
            this.MABAN.Visible = true;
            this.MABAN.VisibleIndex = 1;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.Caption = "TỔNG TIỀN";
            this.TONGTIEN.FieldName = "TONGTIEN";
            this.TONGTIEN.Image = ((System.Drawing.Image)(resources.GetObject("TONGTIEN.Image")));
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.OptionsColumn.ReadOnly = true;
            this.TONGTIEN.Visible = true;
            this.TONGTIEN.VisibleIndex = 2;
            // 
            // THOIGIAN
            // 
            this.THOIGIAN.Caption = "THỜI GIAN";
            this.THOIGIAN.DisplayFormat.FormatString = "d";
            this.THOIGIAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.THOIGIAN.FieldName = "THOIGIAN";
            this.THOIGIAN.Image = ((System.Drawing.Image)(resources.GetObject("THOIGIAN.Image")));
            this.THOIGIAN.Name = "THOIGIAN";
            this.THOIGIAN.OptionsColumn.ReadOnly = true;
            this.THOIGIAN.Visible = true;
            this.THOIGIAN.VisibleIndex = 3;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.Caption = "GIẢM GIÁ";
            this.GIAMGIA.FieldName = "GIAMGIA";
            this.GIAMGIA.Image = ((System.Drawing.Image)(resources.GetObject("GIAMGIA.Image")));
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.OptionsColumn.ReadOnly = true;
            this.GIAMGIA.Visible = true;
            this.GIAMGIA.VisibleIndex = 4;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "MÔ TẢ";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.Image = ((System.Drawing.Image)(resources.GetObject("MOTA.Image")));
            this.MOTA.Name = "MOTA";
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 491);
            this.panel1.TabIndex = 1;
            // 
            // frmDanhSachHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhSachHD";
            this.Text = "DANH SÁCH HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmDanhSachHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn MAHDBH;
        private DevExpress.XtraGrid.Columns.GridColumn MABAN;
        private DevExpress.XtraGrid.Columns.GridColumn TONGTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn THOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn GIAMGIA;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
    }
}