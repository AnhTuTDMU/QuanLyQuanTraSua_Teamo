
namespace GUI
{
    partial class GUI_DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_XemCTHD = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Ngay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_DoanhThu = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_XemCTHD);
            this.panel1.Controls.Add(this.btn_XuatExcel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 343);
            this.panel1.TabIndex = 2;
            // 
            // btn_XemCTHD
            // 
            this.btn_XemCTHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemCTHD.ForeColor = System.Drawing.Color.Black;
            this.btn_XemCTHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemCTHD.Image")));
            this.btn_XemCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemCTHD.Location = new System.Drawing.Point(19, 208);
            this.btn_XemCTHD.Name = "btn_XemCTHD";
            this.btn_XemCTHD.Size = new System.Drawing.Size(283, 54);
            this.btn_XemCTHD.TabIndex = 8;
            this.btn_XemCTHD.Text = "Xem chi tiết hóa đơn";
            this.btn_XemCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XemCTHD.UseVisualStyleBackColor = true;
            this.btn_XemCTHD.Click += new System.EventHandler(this.btn_XemCTHD_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XuatExcel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.Black;
            this.btn_XuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatExcel.Image")));
            this.btn_XuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatExcel.Location = new System.Drawing.Point(1104, 89);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(178, 54);
            this.btn_XuatExcel.TabIndex = 11;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuatExcel.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lbl_Ngay);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Location = new System.Drawing.Point(19, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(551, 82);
            this.panel5.TabIndex = 11;
            // 
            // lbl_Ngay
            // 
            this.lbl_Ngay.AutoSize = true;
            this.lbl_Ngay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ngay.Location = new System.Drawing.Point(14, 16);
            this.lbl_Ngay.Name = "lbl_Ngay";
            this.lbl_Ngay.Size = new System.Drawing.Size(169, 32);
            this.lbl_Ngay.TabIndex = 2;
            this.lbl_Ngay.Text = "Lọc theo ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_DoanhThu);
            this.panel3.Controls.Add(this.separatorControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1294, 74);
            this.panel3.TabIndex = 5;
            // 
            // lbl_DoanhThu
            // 
            this.lbl_DoanhThu.AutoSize = true;
            this.lbl_DoanhThu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoanhThu.Location = new System.Drawing.Point(70, 14);
            this.lbl_DoanhThu.Name = "lbl_DoanhThu";
            this.lbl_DoanhThu.Size = new System.Drawing.Size(336, 38);
            this.lbl_DoanhThu.TabIndex = 0;
            this.lbl_DoanhThu.Text = "THỐNG KÊ DOANH THU";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(68, 43);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(391, 24);
            this.separatorControl1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 258);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // GUI_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_DoanhThu";
            this.Text = "THỐNG KÊ DOANH THU";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ngay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_DoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_XemCTHD;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.Panel panel5;
    }
}