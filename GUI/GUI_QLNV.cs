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
    public partial class GUI_QLNV : Form
    {
        public GUI_QLNV()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txttendangnhap.Text = "";
            txtmatkhau.Text = "";
            txtemail.Text = "";
            txtsodt.Text = "";
            cbo_Quyen.Text = "";
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = BUS_Nhanvien.Instance.DS_NV();

        }
        //Thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txtmanv.Text;
                string tennhanvien = txttennv.Text;
                string tendangnhap = txttendangnhap.Text;
                string matkhau = txtmatkhau.Text;
                string Email = txtemail.Text;
                int sodt = Convert.ToInt32(txtsodt.Text);
                int quyen = Convert.ToInt32(cbo_Quyen.Text);
                DTO_Nhanvien Nhanvien = new DTO_Nhanvien(manv, tennhanvien, tendangnhap, matkhau, Email, sodt,quyen);
                BUS_Nhanvien.Instance.InsertNhanVien(Nhanvien);
                MessageBox.Show("Bạn đã thêm " + tennhanvien + " thành công!");
                clear();
                dgvhienthi.DataSource = BUS_Nhanvien.Instance.DS_NV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txtmanv.Text;
                string tennhanvien = txttennv.Text;
                string tendangnhap = txttendangnhap.Text;
                string matkhau = txtmatkhau.Text;
                string Email = txtemail.Text;
                int sodt = Convert.ToInt32(txtsodt.Text);
                int quyen = Convert.ToInt32(cbo_Quyen.Text);
                DTO_Nhanvien Nhanvien = new DTO_Nhanvien(manv, tennhanvien, tendangnhap, matkhau, Email, sodt,quyen);
                BUS_Nhanvien.Instance.UpdateNhanvien(Nhanvien);
                MessageBox.Show("Bạn đã sửa " + tennhanvien + " thành công!");
                clear();
                dgvhienthi.DataSource = BUS_Nhanvien.Instance.DS_NV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txtmanv.Text;
                string tennhanvien = txttennv.Text;
                string tendangnhap = txttendangnhap.Text;
                string matkhau = txtmatkhau.Text;
                string Email = txtemail.Text;
                int sodt = Convert.ToInt32(txtsodt.Text);
                int quyen = Convert.ToInt32(cbo_Quyen.Text);
                DTO_Nhanvien Nhanvien = new DTO_Nhanvien(manv, tennhanvien, tendangnhap, matkhau, Email, sodt,quyen);
                BUS_Nhanvien.Instance.DeleteNhanvien(manv);
                MessageBox.Show("Bạn đã xóa " + tennhanvien + " thành công!");
                clear();
                dgvhienthi.DataSource = BUS_Nhanvien.Instance.DS_NV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Tim
        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txttim.Text;

                DTO_Nhanvien Nhanvien = new DTO_Nhanvien(manv);
                BUS_Nhanvien.Instance.search(manv);
                dgvhienthi.DataSource = BUS_Nhanvien.Instance.search(manv);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvhienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvhienthi.Rows[e.RowIndex];
                txtmanv.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                txttendangnhap.Text = row.Cells[2].Value.ToString();
                txtmatkhau.Text = row.Cells[3].Value.ToString();
                txtemail.Text = row.Cells[4].Value.ToString();
                txtsodt.Text = row.Cells[5].Value.ToString();
                cbo_Quyen.Text = row.Cells[6].Value.ToString();

            }
            catch { }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            this.Close();


        }

    }
    
}

    