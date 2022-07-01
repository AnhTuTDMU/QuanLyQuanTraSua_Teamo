
namespace GUI
{
    partial class GUI_Hoadonchitiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Hoadonchitiet));
            this.dataGridView_HDCT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_XuatExcelHDCT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Hoadonchitiet = new System.Windows.Forms.Label();
            this.btn_InHoadon = new System.Windows.Forms.Button();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Xem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDCT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_HDCT
            // 
            this.dataGridView_HDCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HDCT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_HDCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HDCT.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_HDCT.Name = "dataGridView_HDCT";
            this.dataGridView_HDCT.RowHeadersWidth = 51;
            this.dataGridView_HDCT.RowTemplate.Height = 24;
            this.dataGridView_HDCT.Size = new System.Drawing.Size(767, 362);
            this.dataGridView_HDCT.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView_HDCT);
            this.panel1.Location = new System.Drawing.Point(12, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 366);
            this.panel1.TabIndex = 1;
            // 
            // btn_XuatExcelHDCT
            // 
            this.btn_XuatExcelHDCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcelHDCT.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatExcelHDCT.Image")));
            this.btn_XuatExcelHDCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatExcelHDCT.Location = new System.Drawing.Point(621, 80);
            this.btn_XuatExcelHDCT.Name = "btn_XuatExcelHDCT";
            this.btn_XuatExcelHDCT.Size = new System.Drawing.Size(162, 57);
            this.btn_XuatExcelHDCT.TabIndex = 2;
            this.btn_XuatExcelHDCT.Text = "Xuất Excel";
            this.btn_XuatExcelHDCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuatExcelHDCT.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Hoadonchitiet
            // 
            this.lbl_Hoadonchitiet.AutoSize = true;
            this.lbl_Hoadonchitiet.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoadonchitiet.Location = new System.Drawing.Point(309, 41);
            this.lbl_Hoadonchitiet.Name = "lbl_Hoadonchitiet";
            this.lbl_Hoadonchitiet.Size = new System.Drawing.Size(271, 38);
            this.lbl_Hoadonchitiet.TabIndex = 4;
            this.lbl_Hoadonchitiet.Text = "HÓA ĐƠN CHI TIẾT";
            // 
            // btn_InHoadon
            // 
            this.btn_InHoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_InHoadon.Image")));
            this.btn_InHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHoadon.Location = new System.Drawing.Point(621, 160);
            this.btn_InHoadon.Name = "btn_InHoadon";
            this.btn_InHoadon.Size = new System.Drawing.Size(162, 57);
            this.btn_InHoadon.TabIndex = 2;
            this.btn_InHoadon.Text = "In hóa đơn";
            this.btn_InHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHoadon.UseVisualStyleBackColor = true;
            this.btn_InHoadon.Click += new System.EventHandler(this.btn_InHoadon_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(329, 82);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(231, 32);
            this.separatorControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Xem);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(286, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 89);
            this.panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 30);
            this.textBox1.TabIndex = 7;
            // 
            // btn_Xem
            // 
            this.btn_Xem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xem.Image")));
            this.btn_Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xem.Location = new System.Drawing.Point(198, 13);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(111, 60);
            this.btn_Xem.TabIndex = 8;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // GUI_Hoadonchitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lbl_Hoadonchitiet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_InHoadon);
            this.Controls.Add(this.btn_XuatExcelHDCT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GUI_Hoadonchitiet";
            this.Text = "Hóa đơn chi tiết";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDCT)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XuatExcelHDCT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Hoadonchitiet;
        private System.Windows.Forms.Button btn_InHoadon;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView_HDCT;
    }
}