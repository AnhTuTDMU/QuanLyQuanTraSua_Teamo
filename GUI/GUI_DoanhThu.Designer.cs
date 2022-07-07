#pragma warning disable 0436
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
            this.btn_MoFileExcel = new System.Windows.Forms.Panel();
            this.btn_XemCTHD = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_Tungay = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_DoanhThu = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_MoFileExcel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Tungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Tungay.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MoFileExcel
            // 
            this.btn_MoFileExcel.Controls.Add(this.button1);
            this.btn_MoFileExcel.Controls.Add(this.btn_XemCTHD);
            this.btn_MoFileExcel.Controls.Add(this.btn_XuatExcel);
            this.btn_MoFileExcel.Controls.Add(this.panel4);
            this.btn_MoFileExcel.Controls.Add(this.panel3);
            this.btn_MoFileExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MoFileExcel.Location = new System.Drawing.Point(0, 0);
            this.btn_MoFileExcel.Name = "btn_MoFileExcel";
            this.btn_MoFileExcel.Size = new System.Drawing.Size(1294, 347);
            this.btn_MoFileExcel.TabIndex = 2;
            // 
            // btn_XemCTHD
            // 
            this.btn_XemCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XemCTHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemCTHD.ForeColor = System.Drawing.Color.Black;
            this.btn_XemCTHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemCTHD.Image")));
            this.btn_XemCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemCTHD.Location = new System.Drawing.Point(12, 213);
            this.btn_XemCTHD.Name = "btn_XemCTHD";
            this.btn_XemCTHD.Size = new System.Drawing.Size(283, 58);
            this.btn_XemCTHD.TabIndex = 8;
            this.btn_XemCTHD.Text = "Xem chi tiết hóa đơn";
            this.btn_XemCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XemCTHD.UseVisualStyleBackColor = true;
            this.btn_XemCTHD.Click += new System.EventHandler(this.btn_XemCTHD_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XuatExcel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.Black;
            this.btn_XuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatExcel.Image")));
            this.btn_XuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatExcel.Location = new System.Drawing.Point(339, 213);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(178, 58);
            this.btn_XuatExcel.TabIndex = 11;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuatExcel.UseVisualStyleBackColor = true;
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.dateEdit1);
            this.panel4.Controls.Add(this.dateEdit_Tungay);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 107);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(591, 40);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(142, 22);
            this.dateEdit1.TabIndex = 3;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit_Tungay_EditValueChanged);
            // 
            // dateEdit_Tungay
            // 
            this.dateEdit_Tungay.EditValue = null;
            this.dateEdit_Tungay.Location = new System.Drawing.Point(189, 41);
            this.dateEdit_Tungay.Name = "dateEdit_Tungay";
            this.dateEdit_Tungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Tungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Tungay.Size = new System.Drawing.Size(142, 22);
            this.dateEdit_Tungay.TabIndex = 3;
            this.dateEdit_Tungay.EditValueChanged += new System.EventHandler(this.dateEdit_Tungay_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(455, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc từ ngày";
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
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 254);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(554, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mở File Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_MoFileExcel);
            this.Name = "GUI_DoanhThu";
            this.Text = "THỐNG KÊ DOANH THU";
            this.btn_MoFileExcel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Tungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Tungay.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel btn_MoFileExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_DoanhThu;
        private System.Windows.Forms.Button btn_XemCTHD;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit_Tungay;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}