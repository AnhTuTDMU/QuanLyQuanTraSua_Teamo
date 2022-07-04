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
    public partial class Report_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public Report_HoaDon()
        {
            InitializeComponent();
            showHD();
        }
        public Report_HoaDon(List<DTO_HoaDon> hoadon) // in lai hóa đơn
        {
            InitializeComponent();
            XtraReport1 xreop = new XtraReport1();
            xreop.Nhapdata(hoadon);
            documentViewer1.DocumentSource = xreop;
        }
        public void showHD()
        {
            string ten;
            int sl, gia;
            List<DTO_HoaDon> hd = new List<DTO_HoaDon>();
            DataTable b = BUS_Hoadon.Instance.Lay_IdBill();
            int id = int.Parse(b.Rows[0].ItemArray[0].ToString());
            DataTable tb = BUS_Hoadon.Instance.Xem_Bill(id);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                ten = tb.Rows[i]["Ten_mon"].ToString();
                sl = int.Parse(tb.Rows[i]["So_luong"].ToString());
                gia = int.Parse(tb.Rows[i]["Gia"].ToString());
                hd.Add(new DTO_HoaDon(ten, sl, gia));
            }
            XtraReport1 xreop = new XtraReport1();
            xreop.Nhapdata(hd);
            documentViewer1.DocumentSource = xreop;
        }
    }
}