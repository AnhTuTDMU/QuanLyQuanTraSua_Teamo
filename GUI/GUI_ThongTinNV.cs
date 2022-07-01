﻿using DevExpress.XtraEditors;
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
    public partial class GUI_ThongTinNV : DevExpress.XtraEditors.XtraForm
    {
        string ten = null;
        public GUI_ThongTinNV(string ten)
        {
            InitializeComponent();
            this.ten = ten;
            DataTable tb = BUS_Nhanvien.Instance.Xem_TTNV(ten);
            lbl_MaNV.Text = tb.Rows[0]["Mã nhân viên"].ToString();
            lbl_Tennv.Text = tb.Rows[0]["Tên nhân viên"].ToString();
            lbl_Email.Text = tb.Rows[0]["Email"].ToString();
            lbl_Sdt.Text = tb.Rows[0]["Số điện thoại"].ToString();
            if (int.Parse(tb.Rows[0]["Quyền"].ToString()) == 1)
            {
                lbl_Vaitro.Text = "Admin";
            }
            else
            {
                lbl_Vaitro.Text = "Nhân viên";
            }
           
        }
    }
}