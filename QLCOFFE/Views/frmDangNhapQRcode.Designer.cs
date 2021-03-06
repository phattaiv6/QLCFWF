namespace QLCOFFE.Views
{
    partial class frmDangNhapQRcode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWebcam = new System.Windows.Forms.Button();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.cmbCMR = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnQL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 338);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 338);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnWebcam
            // 
            this.btnWebcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebcam.Location = new System.Drawing.Point(216, 523);
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.Size = new System.Drawing.Size(86, 35);
            this.btnWebcam.TabIndex = 4;
            this.btnWebcam.Text = "Webcam";
            this.btnWebcam.UseVisualStyleBackColor = true;
            this.btnWebcam.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(256, 447);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(262, 29);
            this.txtMANV.TabIndex = 7;
            this.txtMANV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCMR
            // 
            this.cmbCMR.FormattingEnabled = true;
            this.cmbCMR.Location = new System.Drawing.Point(170, 388);
            this.cmbCMR.Name = "cmbCMR";
            this.cmbCMR.Size = new System.Drawing.Size(439, 21);
            this.cmbCMR.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnQL
            // 
            this.btnQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQL.Location = new System.Drawing.Point(448, 523);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(86, 35);
            this.btnQL.TabIndex = 8;
            this.btnQL.Text = "Quay Lại";
            this.btnQL.UseVisualStyleBackColor = true;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "MÃ SỐ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CAMERA";
            // 
            // frmDangNhapQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.cmbCMR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWebcam);
            this.MaximizeBox = false;
            this.Name = "frmDangNhapQRcode";
            this.Text = "QR CODE ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhapQRcode_FormClosing);
            this.Load += new System.EventHandler(this.DangNhapQRcode_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWebcam;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.ComboBox cmbCMR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}