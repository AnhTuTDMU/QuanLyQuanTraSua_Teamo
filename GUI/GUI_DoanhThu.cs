using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using BUS;
#pragma warning disable 0436
namespace GUI
{
    public partial class GUI_DoanhThu : DevExpress.XtraEditors.XtraForm
    {
     
        public GUI_DoanhThu()
        {
            InitializeComponent();
         
        }
        private void btn_XemCTHD_Click(object sender, EventArgs e)
        { 
            GUI_Hoadonchitiet cthd = new GUI_Hoadonchitiet();
            cthd.ShowDialog();
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void dateEdit_Tungay_EditValueChanged(object sender, EventArgs e)
        {
            DateTime ngay1 = dateEdit_Tungay.DateTime;
            DateTime ngay2 = dateEdit1.DateTime;
            
            dataGridView1.DataSource = BUS_Thongke.Instance.ThongKe_NhieuNgay(ngay1, ngay2);
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = " Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }

            }
        }
        
    }
}