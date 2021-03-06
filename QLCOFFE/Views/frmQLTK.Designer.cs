namespace QLCOFFE.Views
{
    partial class frmQLTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTK));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDANGNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnencry = new System.Windows.Forms.Button();
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
            this.gridControl1.Size = new System.Drawing.Size(1010, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV,
            this.TENNV,
            this.CHUCVU,
            this.TENDANGNHAP,
            this.MATKHAU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MANV
            // 
            this.MANV.Caption = "MÃ NHÂN VIÊN";
            this.MANV.FieldName = "MANV";
            this.MANV.Image = ((System.Drawing.Image)(resources.GetObject("MANV.Image")));
            this.MANV.Name = "MANV";
            this.MANV.OptionsColumn.ReadOnly = true;
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            // 
            // TENNV
            // 
            this.TENNV.Caption = "TÊN NHÂN VIÊN";
            this.TENNV.FieldName = "TENNV";
            this.TENNV.Image = ((System.Drawing.Image)(resources.GetObject("TENNV.Image")));
            this.TENNV.Name = "TENNV";
            this.TENNV.Visible = true;
            this.TENNV.VisibleIndex = 1;
            // 
            // CHUCVU
            // 
            this.CHUCVU.Caption = "CHỨC VỤ";
            this.CHUCVU.FieldName = "CHUCVU";
            this.CHUCVU.Image = ((System.Drawing.Image)(resources.GetObject("CHUCVU.Image")));
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.Visible = true;
            this.CHUCVU.VisibleIndex = 2;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Caption = "TÊN ĐĂNG NHẬP";
            this.TENDANGNHAP.FieldName = "TENDANGNHAP";
            this.TENDANGNHAP.Image = ((System.Drawing.Image)(resources.GetObject("TENDANGNHAP.Image")));
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.OptionsColumn.ReadOnly = true;
            this.TENDANGNHAP.Visible = true;
            this.TENDANGNHAP.VisibleIndex = 3;
            // 
            // MATKHAU
            // 
            this.MATKHAU.Caption = "MẬT KHẨU";
            this.MATKHAU.FieldName = "MATKHAU";
            this.MATKHAU.Image = ((System.Drawing.Image)(resources.GetObject("MATKHAU.Image")));
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Visible = true;
            this.MATKHAU.VisibleIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLCOFFE.Properties.Resources.filesaveas;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1136, 241);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1028, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1028, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1025, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1025, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu MD5";
            // 
            // btnencry
            // 
            this.btnencry.Image = ((System.Drawing.Image)(resources.GetObject("btnencry.Image")));
            this.btnencry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnencry.Location = new System.Drawing.Point(1120, 149);
            this.btnencry.Name = "btnencry";
            this.btnencry.Size = new System.Drawing.Size(125, 40);
            this.btnencry.TabIndex = 8;
            this.btnencry.Text = "CHUYỂN ĐỔI";
            this.btnencry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnencry.UseVisualStyleBackColor = true;
            this.btnencry.Click += new System.EventHandler(this.btnencry_Click_1);
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 450);
            this.Controls.Add(this.btnencry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Name = "frmQLTK";
            this.Text = "QUẢN LÝ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmNhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn TENNV;
        private DevExpress.XtraGrid.Columns.GridColumn CHUCVU;
        private DevExpress.XtraGrid.Columns.GridColumn TENDANGNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn MATKHAU;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnencry;
    }
}