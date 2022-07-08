using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using BUS;
using DTO;
#pragma warning disable 0436
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
            for (int i = 0; i < dataGridView_HDCT.Rows.Count -1 ; i++)
            {
                string mon = dataGridView_HDCT.Rows[i].Cells["Ten_mon"].Value.ToString();
                int sl = int.Parse(dataGridView_HDCT.Rows[i].Cells["So_luong"].Value.ToString());
                int gia = int.Parse(dataGridView_HDCT.Rows[i].Cells["Gia"].Value.ToString());
                int giamgia = int.Parse(dataGridView_HDCT.Rows[i].Cells["GiamGia"].Value.ToString());
                int ThanhTien = int.Parse(dataGridView_HDCT.Rows[i].Cells["ThanhTien"].Value.ToString()); 
               
                hd.Add(new DTO_HoaDon(mon, sl, gia,giamgia,ThanhTien));
            }
            XtraReport1 xreop = new XtraReport1();
            xreop.Nhapdata(hd);
            Report_HoaDon a = new Report_HoaDon(hd);
            a.ShowDialog();
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView_HDCT.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView_HDCT.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView_HDCT.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_HDCT.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView_HDCT.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btn_XuatExcelHDCT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = " Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }

            }
        }
    }
}
