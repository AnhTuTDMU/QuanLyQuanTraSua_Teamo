using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.IO;
using System.Globalization;
using System.Threading;

namespace GUI
{
    public partial class GUI_HOME : DevExpress.XtraEditors.XtraForm
    {
        private int TongTienBill = 0;
        
        public GUI_HOME()
        {
            InitializeComponent();
            
        }
        
        #region
        private void btn_Trasua_MouseHover(object sender, EventArgs e)
        {
            btn_Trasua.BackColor = Color.White;
            btn_Trasua.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Trasua.ForeColor = Color.Black;
        }

        private void btn_Trasua_MouseLeave(object sender, EventArgs e)
        {
            btn_Trasua.BackColor = Color.White;
            btn_Trasua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Trasua.ForeColor = Color.Orange;
        }

        private void btn_Anvat_MouseHover(object sender, EventArgs e)
        {
            btn_Anvat.BackColor = Color.White;
            btn_Anvat.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Anvat.ForeColor = Color.Black;
        }

        private void btn_Anvat_MouseLeave(object sender, EventArgs e)
        {
            btn_Anvat.BackColor = Color.White;
            btn_Anvat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Anvat.ForeColor = Color.Orange;
        }

        private void btn_Topping_MouseHover(object sender, EventArgs e)
        {
            btn_Topping.BackColor = Color.White;
            btn_Topping.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Topping.ForeColor = Color.Black;
        }

        private void btn_Topping_MouseLeave(object sender, EventArgs e)
        {
            btn_Topping.BackColor = Color.White;
            btn_Topping.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Topping.ForeColor = Color.Orange;
        }

        private void btn_Dongchai_MouseHover(object sender, EventArgs e)
        {
            btn_Dongchai.BackColor = Color.White;
            btn_Dongchai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Dongchai.ForeColor = Color.Black;
        }

        private void btn_Dongchai_MouseLeave(object sender, EventArgs e)
        {
            btn_Dongchai.BackColor = Color.White;
            btn_Dongchai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Dongchai.ForeColor = Color.Orange;
        }
        private void btn_ThanhToan_MouseHover(object sender, EventArgs e)
        {
            btn_ThanhToan.BackColor = Color.Aqua;
        }

        private void btn_ThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btn_ThanhToan.BackColor = Color.White;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_HOME));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Trasua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Dongchai = new System.Windows.Forms.Button();
            this.btn_Topping = new System.Windows.Forms.Button();
            this.btn_Anvat = new System.Windows.Forms.Button();
            this.panel_top = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_right = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Giamgia = new System.Windows.Forms.Label();
            this.cbo_Giamgia = new System.Windows.Forms.ComboBox();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_DanhSachmon = new System.Windows.Forms.DataGridView();
            this.Ten_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_right)).BeginInit();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Trasua
            // 
            this.btn_Trasua.BackColor = System.Drawing.Color.White;
            this.btn_Trasua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Trasua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Trasua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Trasua.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Trasua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Trasua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Trasua.Image")));
            this.btn_Trasua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Trasua.Location = new System.Drawing.Point(43, 210);
            this.btn_Trasua.Name = "btn_Trasua";
            this.btn_Trasua.Size = new System.Drawing.Size(112, 90);
            this.btn_Trasua.TabIndex = 1;
            this.btn_Trasua.Text = "Trà sữa";
            this.btn_Trasua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Trasua.UseVisualStyleBackColor = false;
            this.btn_Trasua.Click += new System.EventHandler(this.btn_Trasua_Click);
            this.btn_Trasua.MouseLeave += new System.EventHandler(this.btn_Trasua_MouseLeave);
            this.btn_Trasua.MouseHover += new System.EventHandler(this.btn_Trasua_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_Dongchai);
            this.panelControl1.Controls.Add(this.btn_Topping);
            this.panelControl1.Controls.Add(this.btn_Anvat);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.btn_Trasua);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(208, 714);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_Dongchai
            // 
            this.btn_Dongchai.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Dongchai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Dongchai.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dongchai.Image")));
            this.btn_Dongchai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Dongchai.Location = new System.Drawing.Point(43, 581);
            this.btn_Dongchai.Name = "btn_Dongchai";
            this.btn_Dongchai.Size = new System.Drawing.Size(112, 89);
            this.btn_Dongchai.TabIndex = 3;
            this.btn_Dongchai.Text = "Đóng chai";
            this.btn_Dongchai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Dongchai.UseVisualStyleBackColor = true;
            this.btn_Dongchai.MouseLeave += new System.EventHandler(this.btn_Dongchai_MouseLeave);
            this.btn_Dongchai.MouseHover += new System.EventHandler(this.btn_Dongchai_MouseHover);
            // 
            // btn_Topping
            // 
            this.btn_Topping.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Topping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Topping.Image = ((System.Drawing.Image)(resources.GetObject("btn_Topping.Image")));
            this.btn_Topping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Topping.Location = new System.Drawing.Point(43, 459);
            this.btn_Topping.Name = "btn_Topping";
            this.btn_Topping.Size = new System.Drawing.Size(112, 88);
            this.btn_Topping.TabIndex = 3;
            this.btn_Topping.Text = "Topping";
            this.btn_Topping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Topping.UseVisualStyleBackColor = true;
            this.btn_Topping.MouseLeave += new System.EventHandler(this.btn_Topping_MouseLeave);
            this.btn_Topping.MouseHover += new System.EventHandler(this.btn_Topping_MouseHover);
            // 
            // btn_Anvat
            // 
            this.btn_Anvat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Anvat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Anvat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Anvat.Image")));
            this.btn_Anvat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Anvat.Location = new System.Drawing.Point(43, 336);
            this.btn_Anvat.Name = "btn_Anvat";
            this.btn_Anvat.Size = new System.Drawing.Size(112, 88);
            this.btn_Anvat.TabIndex = 3;
            this.btn_Anvat.Text = "Ăn vặt";
            this.btn_Anvat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Anvat.UseVisualStyleBackColor = true;
            this.btn_Anvat.Click += new System.EventHandler(this.btn_Anvat_Click);
            this.btn_Anvat.MouseLeave += new System.EventHandler(this.btn_Anvat_MouseLeave);
            this.btn_Anvat.MouseHover += new System.EventHandler(this.btn_Anvat_MouseHover);
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_top.Appearance.Options.UseBackColor = true;
            this.panel_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_top.Controls.Add(this.labelControl1);
            this.panel_top.Location = new System.Drawing.Point(235, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1047, 66);
            this.panel_top.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("VNI Russia", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent;
            this.labelControl1.AppearanceDisabled.Options.UseBackColor = true;
            this.labelControl1.AppearanceHovered.BackColor = System.Drawing.Color.Black;
            this.labelControl1.AppearanceHovered.BackColor2 = System.Drawing.Color.Chartreuse;
            this.labelControl1.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.labelControl1.AppearanceHovered.Font = new System.Drawing.Font("VNI Greece", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.labelControl1.AppearanceHovered.Options.UseBackColor = true;
            this.labelControl1.AppearanceHovered.Options.UseBorderColor = true;
            this.labelControl1.AppearanceHovered.Options.UseFont = true;
            this.labelControl1.AppearanceHovered.Options.UseForeColor = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelControl1.Location = new System.Drawing.Point(0, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 47);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MENU";
            // 
            // panel_right
            // 
            this.panel_right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_right.Controls.Add(this.panelControl3);
            this.panel_right.Controls.Add(this.panel1);
            this.panel_right.Controls.Add(this.panelControl2);
            this.panel_right.Location = new System.Drawing.Point(747, 72);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(530, 628);
            this.panel_right.TabIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.lbl_Giamgia);
            this.panelControl3.Controls.Add(this.cbo_Giamgia);
            this.panelControl3.Controls.Add(this.txt_Tongtien);
            this.panelControl3.Controls.Add(this.btn_ThanhToan);
            this.panelControl3.Location = new System.Drawing.Point(7, 499);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(518, 124);
            this.panelControl3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "%";
            // 
            // lbl_Giamgia
            // 
            this.lbl_Giamgia.AutoSize = true;
            this.lbl_Giamgia.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Giamgia.Location = new System.Drawing.Point(33, 16);
            this.lbl_Giamgia.Name = "lbl_Giamgia";
            this.lbl_Giamgia.Size = new System.Drawing.Size(106, 29);
            this.lbl_Giamgia.TabIndex = 3;
            this.lbl_Giamgia.Text = "Giảm giá";
            // 
            // cbo_Giamgia
            // 
            this.cbo_Giamgia.FormattingEnabled = true;
            this.cbo_Giamgia.Items.AddRange(new object[] {
            "0",
            "10"});
            this.cbo_Giamgia.Location = new System.Drawing.Point(154, 23);
            this.cbo_Giamgia.Name = "cbo_Giamgia";
            this.cbo_Giamgia.Size = new System.Drawing.Size(64, 24);
            this.cbo_Giamgia.TabIndex = 2;
            this.cbo_Giamgia.Tag = "0";
            this.cbo_Giamgia.SelectedValueChanged += new System.EventHandler(this.cbo_Giamgia_SelectedValueChanged);
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.BackColor = System.Drawing.Color.White;
            this.txt_Tongtien.Enabled = false;
            this.txt_Tongtien.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_Tongtien.Location = new System.Drawing.Point(28, 61);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Tongtien.Size = new System.Drawing.Size(250, 38);
            this.txt_Tongtien.TabIndex = 1;
            this.txt_Tongtien.Text = "0";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btn_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThanhToan.Image")));
            this.btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.Location = new System.Drawing.Point(332, 43);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(172, 56);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            this.btn_ThanhToan.MouseLeave += new System.EventHandler(this.btn_ThanhToan_MouseLeave);
            this.btn_ThanhToan.MouseHover += new System.EventHandler(this.btn_ThanhToan_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView_DanhSachmon);
            this.panel1.Location = new System.Drawing.Point(5, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 409);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView_DanhSachmon
            // 
            this.dataGridView_DanhSachmon.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.dataGridView_DanhSachmon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_DanhSachmon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachmon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_DanhSachmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_Mon,
            this.So_luong,
            this.Gia_Mon});
            this.dataGridView_DanhSachmon.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DanhSachmon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_DanhSachmon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DanhSachmon.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_DanhSachmon.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_DanhSachmon.Name = "dataGridView_DanhSachmon";
            this.dataGridView_DanhSachmon.RowHeadersVisible = false;
            this.dataGridView_DanhSachmon.RowHeadersWidth = 51;
            this.dataGridView_DanhSachmon.RowTemplate.Height = 24;
            this.dataGridView_DanhSachmon.Size = new System.Drawing.Size(520, 409);
            this.dataGridView_DanhSachmon.TabIndex = 0;
            // 
            // Ten_Mon
            // 
            this.Ten_Mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_Mon.HeaderText = "Tên Món";
            this.Ten_Mon.MinimumWidth = 6;
            this.Ten_Mon.Name = "Ten_Mon";
            this.Ten_Mon.ReadOnly = true;
            // 
            // So_luong
            // 
            this.So_luong.HeaderText = "Số lượng";
            this.So_luong.MinimumWidth = 6;
            this.So_luong.Name = "So_luong";
            this.So_luong.Width = 125;
            // 
            // Gia_Mon
            // 
            this.Gia_Mon.HeaderText = "Giá Món";
            this.Gia_Mon.MinimumWidth = 6;
            this.Gia_Mon.Name = "Gia_Mon";
            this.Gia_Mon.Width = 125;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btn_Xoa);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(7, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(518, 73);
            this.panelControl2.TabIndex = 1;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(385, 13);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 39);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa tất cả";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.labelControl2.Location = new System.Drawing.Point(28, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 34);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Món đã chọn";
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Controls.Add(this.flowLayoutPanel1);
            this.panelControl4.Location = new System.Drawing.Point(235, 72);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(511, 630);
            this.panelControl4.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 626);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GUI_HOME
            // 
            this.ActiveGlowColor = System.Drawing.Color.Transparent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 714);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_HOME";
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_right)).EndInit();
            this.panel_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion/*
        private void AddItem(string name, string gia,byte[] img)
        {
            var w = new UserControl_Tea()
            {

                Title = name,
                Gia = gia,
                icon = byteArrayToImage(img)
            };
           
            flowLayoutPanel1.Controls.Add(w);
            
            w.Onselect += (ss, ee) =>
            {

                var uc = ss as UserControl_Tea;
        
                if (dataGridView_DanhSachmon.Rows.Count == 0)
                {
                    dataGridView_DanhSachmon.Rows.Add(new object[] { uc.lbl_Title.Text,1, uc.lbl_Gia.Text });
                }
                else
                {
                    int flag = 0;
                    for(int i =0; i < dataGridView_DanhSachmon.Rows.Count ; i++)
                    {
                        if(dataGridView_DanhSachmon.Rows[i].Cells[0].Value.ToString() == uc.lbl_Title.Text)
                        {
                            dataGridView_DanhSachmon.Rows[i].Cells[1].Value = int.Parse(dataGridView_DanhSachmon.Rows[i].Cells[1].Value.ToString()) + 1;
                            dataGridView_DanhSachmon.Rows[i].Cells[2].Value = int.Parse(dataGridView_DanhSachmon.Rows[i].Cells[2].Value.ToString()) + int.Parse(uc.lbl_Gia.Text);
                            
                            flag = 1;
                            break;
                        }
                        
                    }
                    if(flag == 0)
                    {
                        dataGridView_DanhSachmon.Rows.Add(new object[] { uc.lbl_Title.Text,1, uc.lbl_Gia.Text });
                    }
                }
         
                TongTien();

            };
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dataGridView_DanhSachmon.Rows.Clear();
            txt_Tongtien.Text = "0";
        }
        private void cbo_Giamgia_SelectedValueChanged(object sender, EventArgs e)
        {
            float tongtien = 0;
            tongtien += float.Parse(txt_Tongtien.Text);
            if(cbo_Giamgia.SelectedItem.ToString() == "0")
            {
                txt_Tongtien.Text = tongtien.ToString();
            }
            else if (cbo_Giamgia.SelectedItem.ToString() == "10")
            {
                tongtien *= (float)0.9;
                txt_Tongtien.Text = tongtien.ToString();
            }
  
        }
        private void TongTien()
        {
            int tt = 0;
            if (dataGridView_DanhSachmon.Rows.Count != 0)
            {
                for (int i = 0; i < dataGridView_DanhSachmon.Rows.Count; i++)
                {
                    tt += int.Parse(dataGridView_DanhSachmon.Rows[i].Cells[2].Value.ToString());
                }
                txt_Tongtien.Text = tt.ToString();
            }
        }
        private void btn_Trasua_Click(object sender, EventArgs e)
        {
           
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = BUS_Danhsachmon.Instance.DS_Douong();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                AddItem(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), (byte[])dt.Rows[i].ItemArray[2]);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            int tong = 0;
            BUS_Hoadon.Instance.Luu_IdBill(DateTime.Now,tong); // lưu vào hoadon(id tự tăng)
            DataTable tb = BUS_Hoadon.Instance.Lay_IdBill();
            int idbill = int.Parse(tb.Rows[0].ItemArray[0].ToString());
            for (int i = 0; i < dataGridView_DanhSachmon.Rows.Count; i++)
            {
                BUS_Hoadon.Instance.Luu_Bill(idbill,dataGridView_DanhSachmon.Rows[i].Cells[0].Value.ToString(), int.Parse(dataGridView_DanhSachmon.Rows[i].Cells[1].Value.ToString()), int.Parse(dataGridView_DanhSachmon.Rows[i].Cells[2].Value.ToString()));
            }
            MessageBox.Show("Thanh toán thành công " + "Tổng tiền là : " + txt_Tongtien.Text);
            tong = int.Parse(txt_Tongtien.Text);
            BUS_Hoadon.Instance.Capnhat_TongTien(idbill, tong); // update tổng tiền xuống hoadon

            Report_HoaDon report = new Report_HoaDon();
            report.ShowDialog();
            dataGridView_DanhSachmon.Rows.Clear();
            txt_Tongtien.Text = "0";
            
        }

        private void btn_Anvat_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            DataTable dt = BUS_Danhsachmon.Instance.DS_Monan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddItem(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), (byte[])dt.Rows[i].ItemArray[2]);
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn) // hàm lấy load ảnh lên từ sql
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

      
    }
}
