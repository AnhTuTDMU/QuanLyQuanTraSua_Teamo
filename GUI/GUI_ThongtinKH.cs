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
using BUS;
namespace GUI
{
    public partial class GUI_ThongtinKH : DevExpress.XtraEditors.XtraForm
    {
        public GUI_ThongtinKH()
        {
            InitializeComponent();
        }

        private void GUI_ThongtinKH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUS_Khachhang.Instance.Xem_TT_TatcaKH();
            
        }
    }
}