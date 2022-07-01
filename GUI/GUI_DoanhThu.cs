using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class GUI_DoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public GUI_DoanhThu()
        {
            InitializeComponent();
         
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;

            dataGridView1.DataSource = BUS_Thongke.Instance.ThongKe_TheoNgay(date);
            
        }

        private void btn_XemCTHD_Click(object sender, EventArgs e)
        { 
            GUI_Hoadonchitiet cthd = new GUI_Hoadonchitiet();
            cthd.ShowDialog();
        }
    }
}