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
using DevExpress.XtraSplashScreen;
using System.Threading;
using DTO;
namespace GUI
{
    
    public partial class GUI_Login : DevExpress.XtraEditors.XtraForm
    {
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
           
            SplashScreenManager.ShowForm(typeof(Load));
            Thread.Sleep(1500);
            if (txt_Taikhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản ! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Matkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu khoản ! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS_Login.Instance.Check_Login(txt_Taikhoan.Text, txt_Matkhau.Text))
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("Đăng nhập thành công ! " + "Hôm nay là ngày: " + DateTime.Now.ToString("dd/MM/yyyy"), "Thông báo !", MessageBoxButtons.OK);
                this.Hide();
                var home = new GUI_MDI_Home(txt_Taikhoan.Text);
                home.Show();
                home.Logout += Home_Logout;

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }

        private void Home_Logout(object sender, EventArgs e)
        {
            (sender as GUI_MDI_Home).IsExit = false;
            (sender as GUI_MDI_Home).Close();
            this.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void ckb_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_hienmatkhau.Checked == true)
            {
                txt_Matkhau.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Matkhau.UseSystemPasswordChar = false;
            }
        }
    }
}