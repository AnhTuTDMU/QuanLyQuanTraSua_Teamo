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
using DTO;
namespace GUI
{
    public partial class GUI_Hoadonchitiet : Form
    {
        public GUI_Hoadonchitiet()
        {
            InitializeComponent();
            dataGridView_HDCT.Show();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID hóa đơn để xem chi tiết", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_HDCT.DataSource = BUS_Thongke.Instance.Xem_Hoadonchitiet(int.Parse(textBox1.Text));
            }
        }

        private void btn_InHoadon_Click(object sender, EventArgs e)
        {
            List<DTO_HoaDon> hd = new List<DTO_HoaDon>();
            
            DTO_HoaDon dto = new DTO_HoaDon();
          
            /* foreach(DataGridViewRow item in dataGridView_HDCT.SelectedRows)
             {
                 MessageBox.Show(item..Value.ToString());
             }*/
            for (int i = 0; i < dataGridView_HDCT.Rows.Count -1 ; i++)
            {
            //    int rowindex = dataGridView_HDCT.CurrentCell.RowIndex;
           //     dataGridView_HDCT.Rows[i].Cells["ID"].Value.ToString();
                string mon = dataGridView_HDCT.Rows[i].Cells["Ten_mon"].Value.ToString();
                int sl = int.Parse(dataGridView_HDCT.Rows[i].Cells["So_luong"].Value.ToString());
                int gia = int.Parse(dataGridView_HDCT.Rows[i].Cells["Gia"].Value.ToString());

                hd.Add(new DTO_HoaDon(mon, sl, gia));
            }
            XtraReport1 xreop = new XtraReport1();
            xreop.Nhapdata(hd);
            Report_HoaDon a = new Report_HoaDon(hd);
            a.ShowDialog();
        }
    }
}
