using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class GUI_MDI_Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string Ten_Dn = null;
        public bool IsExit = true;
        int checkquyen = -1;
        public event EventHandler Logout;
        public GUI_MDI_Home()
        {
            InitializeComponent();
        }
        public GUI_MDI_Home(string ten_Dn)
        {
            InitializeComponent();
            this.Ten_Dn = ten_Dn;
            DataTable tb = BUS_Nhanvien.Instance.Xem_TTNV(ten_Dn);
            checkquyen = int.Parse(tb.Rows[0]["QUyền"].ToString());
            if(checkquyen == 0)
            {
                ribbonPage_Quanly.Visible = false;
                ribbonPage_Thongke.Visible = false;
            }
            else
            {
                ribbonPage_Quanly.Visible = true;
                ribbonPage_Thongke.Visible = true;
            }
           
        }

        private void barButtonItem_MENU_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI_HOME gUI_Home = new GUI_HOME();
            gUI_Home.MdiParent = this;
            gUI_Home.Show();
        }

        private void barButtonItem_Themmon_ItemClick(object sender, ItemClickEventArgs e)
        {
                GUI_Monan gUI_Monan = new GUI_Monan();
                gUI_Monan.MdiParent = this;
                gUI_Monan.Show();
        }
        private void barButtonItem_Nhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI_QLNV ql = new GUI_QLNV();
            ql.ShowDialog();

        }
        private void GUI_MDI_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsExit == true)
            {
                if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void GUI_MDI_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(IsExit == true)
            {
                Application.Exit();
            }
            
        }
        private void barButtonItem_Dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout(this, new EventArgs()); 

        }

        private void barButtonItem_TTNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI_ThongTinNV ttnv = new GUI_ThongTinNV(Ten_Dn);
            ttnv.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI_DoanhThu doanhThu = new GUI_DoanhThu();
            doanhThu.MdiParent = this;
            doanhThu.Show();
        }
    }
}