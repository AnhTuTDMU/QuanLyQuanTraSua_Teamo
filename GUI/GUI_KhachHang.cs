using DevExpress.XtraEditors;
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
    public partial class GUI_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void btn_Themkhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txt_TenKH.Text;
                string sdt = txt_Sdt.Text;
                int diem = Convert.ToInt32(txt_Diem.Text);
                DTO_KhachHang khachHang = new DTO_KhachHang(ten,sdt,diem);
                BUS_Khachhang.Instance.Them_Khachhang(khachHang);
                MessageBox.Show("Thêm khách hàng " + txt_TenKH.Text + " thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công" ,ex.Message);
            }
        }
    }
}