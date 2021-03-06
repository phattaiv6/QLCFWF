namespace QLCOFFE.Views
{
    partial class frmGoiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoiMon));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstmonan = new System.Windows.Forms.ListView();
            this.pnlGoiMon = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatMon = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTinhTien = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblmt = new System.Windows.Forms.Label();
            this.cba = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGoiMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMT.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 138;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món ăn";
            this.columnHeader1.Width = 169;
            // 
            // lstmonan
            // 
            this.lstmonan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstmonan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstmonan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstmonan.GridLines = true;
            this.lstmonan.HideSelection = false;
            this.lstmonan.Location = new System.Drawing.Point(9, -2);
            this.lstmonan.Margin = new System.Windows.Forms.Padding(10);
            this.lstmonan.Name = "lstmonan";
            this.lstmonan.Size = new System.Drawing.Size(566, 280);
            this.lstmonan.TabIndex = 0;
            this.lstmonan.UseCompatibleStateImageBehavior = false;
            this.lstmonan.View = System.Windows.Forms.View.Details;
            // 
            // pnlGoiMon
            // 
            this.pnlGoiMon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGoiMon.Controls.Add(this.lstmonan);
            this.pnlGoiMon.Controls.Add(this.btnIn);
            this.pnlGoiMon.Location = new System.Drawing.Point(654, 203);
            this.pnlGoiMon.Name = "pnlGoiMon";
            this.pnlGoiMon.Size = new System.Drawing.Size(578, 297);
            this.pnlGoiMon.TabIndex = 65;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(259, 21);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(120, 58);
            this.btnIn.TabIndex = 60;
            this.btnIn.Text = "In hóa đơn(chưa làm)";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(261, 18);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(120, 20);
            this.nmSoLuong.TabIndex = 3;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTenMon
            // 
            this.cbTenMon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbTenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Location = new System.Drawing.Point(16, 83);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(167, 21);
            this.cbTenMon.TabIndex = 1;
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbLoaiMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(16, 21);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(167, 21);
            this.cbLoaiMon.TabIndex = 0;
            this.cbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMon_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatMon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmSoLuong);
            this.groupBox1.Controls.Add(this.cbTenMon);
            this.groupBox1.Controls.Add(this.cbLoaiMon);
            this.groupBox1.Location = new System.Drawing.Point(654, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 124);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt món";
            // 
            // btnDatMon
            // 
            this.btnDatMon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDatMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatMon.ImageOptions.Image")));
            this.btnDatMon.Location = new System.Drawing.Point(261, 50);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(120, 54);
            this.btnDatMon.TabIndex = 43;
            this.btnDatMon.Text = "Đặt món";
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "%";
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiamGia.Location = new System.Drawing.Point(168, 19);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(96, 20);
            this.btnGiamGia.TabIndex = 9;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(165, 64);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(99, 42);
            this.btnChuyenBan.TabIndex = 8;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(12, 76);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(120, 21);
            this.cbChuyenBan.TabIndex = 7;
            this.cbChuyenBan.SelectedIndexChanged += new System.EventHandler(this.cbChuyenBan_SelectedIndexChanged);
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Location = new System.Drawing.Point(12, 19);
            this.nmGiamGia.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(120, 20);
            this.nmGiamGia.TabIndex = 5;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmGiamGia.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnGiamGia);
            this.groupBox3.Controls.Add(this.btnChuyenBan);
            this.groupBox3.Controls.Add(this.cbChuyenBan);
            this.groupBox3.Controls.Add(this.nmGiamGia);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(1079, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 124);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.flTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(601, 604);
            this.flowLayoutPanel1.TabIndex = 67;
            // 
            // flTable
            // 
            this.flTable.Location = new System.Drawing.Point(3, 3);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(617, 697);
            this.flTable.TabIndex = 48;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTinhTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTien.ImageOptions.Image")));
            this.btnTinhTien.Location = new System.Drawing.Point(1238, 354);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(120, 58);
            this.btnTinhTien.TabIndex = 57;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // cmbMT
            // 
            this.cmbMT.EditValue = "THANH TOÁN";
            this.cmbMT.Location = new System.Drawing.Point(1247, 246);
            this.cmbMT.Name = "cmbMT";
            this.cmbMT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMT.Properties.Items.AddRange(new object[] {
            "THANH TOÁN",
            "HỦY  ĐƠN"});
            this.cmbMT.Size = new System.Drawing.Size(100, 20);
            this.cmbMT.TabIndex = 68;
            // 
            // lblmt
            // 
            this.lblmt.AutoSize = true;
            this.lblmt.Location = new System.Drawing.Point(1244, 203);
            this.lblmt.Name = "lblmt";
            this.lblmt.Size = new System.Drawing.Size(115, 13);
            this.lblmt.TabIndex = 69;
            this.lblmt.Text = "MÔ TẢ THANH TOÁN";
            // 
            // cba
            // 
            this.cba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cba.FormattingEnabled = true;
            this.cba.Location = new System.Drawing.Point(716, 23);
            this.cba.Name = "cba";
            this.cba.Size = new System.Drawing.Size(121, 21);
            this.cba.TabIndex = 70;
            this.cba.SelectedIndexChanged += new System.EventHandler(this.cba_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(1215, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "VND";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Red;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTongTien.Location = new System.Drawing.Point(1062, 23);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(153, 22);
            this.txtTongTien.TabIndex = 72;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Location = new System.Drawing.Point(897, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 33);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tổng tiền thanh toán :";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(169, 14);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 16);
            this.lblTongTien.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Khu vực";
            // 
            // frmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cba);
            this.Controls.Add(this.lblmt);
            this.Controls.Add(this.cmbMT);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.pnlGoiMon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmGoiMon";
            this.Text = "GỌI MÓN";
            this.Load += new System.EventHandler(this.frmGoiMon_Load);
            this.pnlGoiMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMT.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTinhTien;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstmonan;
        private System.Windows.Forms.Panel pnlGoiMon;
        private System.Windows.Forms.Button btnIn;
        private DevExpress.XtraEditors.SimpleButton btnDatMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMT;
        private System.Windows.Forms.Label lblmt;
        private System.Windows.Forms.ComboBox cba;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label4;
    }
}