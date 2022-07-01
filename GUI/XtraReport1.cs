using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DTO;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace GUI
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public void Nhapdata(List<DTO_HoaDon> hd)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-Vn");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            objectDataSource1.DataSource = hd;

            xr_Ngay.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

    }
}
