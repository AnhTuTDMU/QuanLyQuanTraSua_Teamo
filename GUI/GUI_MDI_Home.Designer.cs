#pragma warning disable 0436
namespace GUI
{
    partial class GUI_MDI_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MDI_Home));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_MENU = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Themmon = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItem_Dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_TTNV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_Nhanvien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Giaodien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Maugiaodien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Quanly = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Moan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_TTNV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Thongke = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem_MENU,
            this.barButtonItem_Themmon,
            this.skinRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.barButtonItem_Dangxuat,
            this.barButtonItem_Nhanvien,
            this.barButtonItem_TTNV,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_Nhanvien,
            this.ribbonPage_Quanly,
            this.ribbonPage_Thongke});
            this.ribbon.Size = new System.Drawing.Size(1489, 198);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem_MENU
            // 
            this.barButtonItem_MENU.Caption = "Thực đơn";
            this.barButtonItem_MENU.Id = 1;
            this.barButtonItem_MENU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_MENU.ImageOptions.Image")));
            this.barButtonItem_MENU.Name = "barButtonItem_MENU";
            this.barButtonItem_MENU.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.barButtonItem_MENU.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem_MENU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_MENU_ItemClick);
            // 
            // barButtonItem_Themmon
            // 
            this.barButtonItem_Themmon.Caption = "Thêm món mới";
            this.barButtonItem_Themmon.Id = 3;
            this.barButtonItem_Themmon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Themmon.ImageOptions.Image")));
            this.barButtonItem_Themmon.Name = "barButtonItem_Themmon";
            this.barButtonItem_Themmon.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem_Themmon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Themmon_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 13;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 14;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // barButtonItem_Dangxuat
            // 
            this.barButtonItem_Dangxuat.Caption = "Đăng xuất";
            this.barButtonItem_Dangxuat.Id = 15;
            this.barButtonItem_Dangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Dangxuat.ImageOptions.Image")));
            this.barButtonItem_Dangxuat.Name = "barButtonItem_Dangxuat";
            this.barButtonItem_Dangxuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem_Dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Dangxuat_ItemClick);
            // 
            // barButtonItem_Nhanvien
            // 
            this.barButtonItem_Nhanvien.Caption = "Thông tin nhân viên";
            this.barButtonItem_Nhanvien.Id = 16;
            this.barButtonItem_Nhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Nhanvien.ImageOptions.Image")));
            this.barButtonItem_Nhanvien.Name = "barButtonItem_Nhanvien";
            this.barButtonItem_Nhanvien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem_Nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Nhanvien_ItemClick);
            // 
            // barButtonItem_TTNV
            // 
            this.barButtonItem_TTNV.Caption = "Thông tin nhân viên";
            this.barButtonItem_TTNV.Id = 17;
            this.barButtonItem_TTNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_TTNV.ImageOptions.Image")));
            this.barButtonItem_TTNV.Name = "barButtonItem_TTNV";
            this.barButtonItem_TTNV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem_TTNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_TTNV_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem Doanh Thu";
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm khách hàng";
            this.barButtonItem2.Id = 19;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage_Nhanvien
            // 
            this.ribbonPage_Nhanvien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup_Giaodien,
            this.ribbonPageGroup_Maugiaodien});
            this.ribbonPage_Nhanvien.Name = "ribbonPage_Nhanvien";
            this.ribbonPage_Nhanvien.Text = "Nhân viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_MENU);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_TTNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhân viên";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_Dangxuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup_Giaodien
            // 
            this.ribbonPageGroup_Giaodien.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup_Giaodien.Name = "ribbonPageGroup_Giaodien";
            this.ribbonPageGroup_Giaodien.Text = "Giao diện";
            // 
            // ribbonPageGroup_Maugiaodien
            // 
            this.ribbonPageGroup_Maugiaodien.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup_Maugiaodien.Name = "ribbonPageGroup_Maugiaodien";
            this.ribbonPageGroup_Maugiaodien.Text = "Màu giao diện";
            // 
            // ribbonPage_Quanly
            // 
            this.ribbonPage_Quanly.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Moan,
            this.ribbonPageGroup_TTNV});
            this.ribbonPage_Quanly.Name = "ribbonPage_Quanly";
            this.ribbonPage_Quanly.Text = "Quản lý";
            // 
            // ribbonPageGroup_Moan
            // 
            this.ribbonPageGroup_Moan.ItemLinks.Add(this.barButtonItem_Themmon);
            this.ribbonPageGroup_Moan.Name = "ribbonPageGroup_Moan";
            this.ribbonPageGroup_Moan.Text = "Thêm món ";
            // 
            // ribbonPageGroup_TTNV
            // 
            this.ribbonPageGroup_TTNV.ItemLinks.Add(this.barButtonItem_Nhanvien);
            this.ribbonPageGroup_TTNV.Name = "ribbonPageGroup_TTNV";
            this.ribbonPageGroup_TTNV.Text = "Nhân viên";
            // 
            // ribbonPage_Thongke
            // 
            this.ribbonPage_Thongke.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage_Thongke.Name = "ribbonPage_Thongke";
            this.ribbonPage_Thongke.Text = "Thống kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống kê doanh thu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 618);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1489, 32);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // GUI_MDI_Home
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 650);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "GUI_MDI_Home";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_MDI_Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_MDI_Home_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Nhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_MENU;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Themmon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Quanly;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Moan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_TTNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Thongke;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Giaodien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Maugiaodien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Dangxuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Nhanvien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_TTNV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}