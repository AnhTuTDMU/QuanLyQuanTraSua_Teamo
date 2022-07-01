﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Hoadon
    {
        private static BUS_Hoadon instance;

        public static BUS_Hoadon Instance
        {
            get { if (instance == null) instance = new BUS_Hoadon(); return instance; }
            private set { instance = value; }
        }

        // Lưu bill
        public void Luu_Bill(int id,string ten,int sl,int gia)
        {
            DAL_Hoadon.Instance.luu_Bill( id,ten,sl,gia);
        }
        // Xem Bill
        public DataTable Xem_Bill(int id)
        {
           return DAL_Hoadon.Instance.Xem_Bill(id);
        }
        // Lưu bill xuống bảng hoadon
        public void Luu_IdBill(DateTime ngaylapbill,int tt)
        {
            DAL_Hoadon.Instance.Luu_idBill(ngaylapbill, tt);
        }
        // Lấy id bill từ hoadon
        public DataTable Lay_IdBill()
        {
            return DAL_Hoadon.Instance.LayIDBill();
        }
        public void Capnhat_TongTien(int id,int TT)
        {
            DAL_Hoadon.Instance.Capnhat_TT(id,TT);
        }
    }
}
