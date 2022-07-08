#pragma warning disable 0436
namespace GUI
{
    partial class GUI_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_KhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Themkhachhang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Themkhachhang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Diem);
            this.panel1.Controls.Add(this.txt_Sdt);
            this.panel1.Controls.Add(this.txt_TenKH);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 164);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm tích lũy";
            // 
            // btn_Themkhachhang
            // 
            this.btn_Themkhachhang.BackColor = System.Drawing.Color.White;
            this.btn_Themkhachhang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Themkhachhang.ForeColor = System.Drawing.Color.Black;
            this.btn_Themkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themkhachhang.Image")));
            this.btn_Themkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Themkhachhang.Location = new System.Drawing.Point(551, 43);
            this.btn_Themkhachhang.Name = "btn_Themkhachhang";
            this.btn_Themkhachhang.Size = new System.Drawing.Size(128, 59);
            this.btn_Themkhachhang.TabIndex = 2;
            this.btn_Themkhachhang.Text = "Thêm";
            this.btn_Themkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Themkhachhang.UseVisualStyleBackColor = false;
            this.btn_Themkhachhang.Click += new System.EventHandler(this.btn_Themkhachhang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng";
            // 
            // txt_Diem
            // 
            this.txt_Diem.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diem.Location = new System.Drawing.Point(246, 111);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(46, 35);
            this.txt_Diem.TabIndex = 0;
            this.txt_Diem.Text = "0";
            this.txt_Diem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sdt.Location = new System.Drawing.Point(246, 67);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(245, 35);
            this.txt_Sdt.TabIndex = 0;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(246, 17);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(245, 35);
            this.txt_TenKH.TabIndex = 0;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.separatorControl1.LineThickness = 10;
            this.separatorControl1.Location = new System.Drawing.Point(4, 8);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(707, 32);
            this.separatorControl1.TabIndex = 2;
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 236);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_KhachHang";
            this.Text = "GUI_KhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Themkhachhang;
        private System.Windows.Forms.TextBox txt_Diem;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}