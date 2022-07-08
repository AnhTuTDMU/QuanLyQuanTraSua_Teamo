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
using System.IO;

namespace GUI
{
    public partial class GUI_Monan : DevExpress.XtraEditors.XtraForm
    {
        private string mon;
        public GUI_Monan()
        {
            InitializeComponent();
        }
        #region
        public void Clear()
        {
            txt_giaban.Text = lbl_Gia.Text = "";
            txt_title.Text = lbl_Title.Text = "";
            pictureBox1.Image = pictureBox2.Image = null;

        }
        public byte[] ConvertImageTobyes(System.Drawing.Image img)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


        public byte[] Savephoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jgp;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);

                }
            }
            pictureBox1.Image = pictureBox2.Image;
        }

        private void txt_title_TextChanged_1(object sender, EventArgs e)
        {
            lbl_Title.Text = txt_title.Text;
        }

        private void txt_giaban_TextChanged_1(object sender, EventArgs e)
        {
            lbl_Gia.Text = txt_giaban.Text;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        // lưu món ăn
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Image img = pictureBox2.Image;
            if (img == null || txt_title.Text == "" || txt_giaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ảnh để có thể lưu món", "Báo Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_title.Text.Equals(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Món đã tồn tại không thể thêm ", "Báo Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txt_title.Text != dataGridView1.CurrentRow.Cells[0].Value.ToString())
            {
                BUS_Danhsachmon.Instance.Them_Mon_an(txt_title.Text, txt_giaban.Text, ConvertImageTobyes(img));
                MessageBox.Show("Thêm thành công món", "Thông báo !", MessageBoxButtons.OK);
                Clear();
                dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Monan();
            }
            
            
        }

        // lưu đồ uống
        private void btn_Luudouong_Click(object sender, EventArgs e)
        {
            Image img = pictureBox2.Image;
            if (img == null || txt_title.Text == "" || txt_giaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ảnh để có thể lưu món", "Báo Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_title.Text.Equals(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Món đã tồn tại không thể thêm ", "Báo Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_title.Text != dataGridView1.CurrentRow.Cells[0].Value.ToString())
            {
                BUS_Danhsachmon.Instance.Them_Thuc_uong(txt_title.Text, txt_giaban.Text, ConvertImageTobyes(img));
                MessageBox.Show("Thêm thành công món", "Thông báo !", MessageBoxButtons.OK);
                Clear();
                dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Douong();
            }
        }

        // xem món ăn
        private void btn_XemMonan_Click(object sender, EventArgs e)
        {
            mon = "Mon_an";
            dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Monan();
        }

        // xem đồ uống
        private void btn_Xemdouong_Click(object sender, EventArgs e)
        {
            mon = "Do_uong";
            dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Douong();
        }

        // xóa món ăn hoặc đồ uống
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món muốn xóa", "Báo Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUS_Danhsachmon.Instance.Xoa_Mon_an(txt_title.Text);
            BUS_Danhsachmon.Instance.Xoa_Thuc_uong(txt_title.Text);
            MessageBox.Show("Xóa thành công");
            Clear();
            dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Monan();
            dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Douong();

        }

        // sửa thức uống
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "" || txt_giaban.Text == ""|| pictureBox2.Image == null)
            {
                MessageBox.Show("Vui lòng chọn món để sửa", "Báo Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn sửa món này không ?", "Thông báo !", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if(mon == "Do_uong")
            {
                BUS_Danhsachmon.Instance.Sua_Thuc_uong(txt_title.Text, txt_giaban.Text, Savephoto());
                MessageBox.Show("Bạn đã sửa thức uống" + txt_title.Text + " thành công!", "Thông báo !", MessageBoxButtons.OK);
                Clear();
                dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Douong();
            }
            else if(mon == "Mon_an")
            {
                BUS_Danhsachmon.Instance.Sua_Mon_an(txt_title.Text, txt_giaban.Text, Savephoto());
                MessageBox.Show("Bạn đã sửa món ăn" + txt_title.Text + " thành công!", "Thông báo !", MessageBoxButtons.OK);
                Clear();
                dataGridView1.DataSource = BUS_Danhsachmon.Instance.DS_Monan();
            }
        }

        //Thao tác trên datagirdview 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_title.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_giaban.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[2].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox2.Image = pictureBox1.Image = Image.FromStream(ms);
          
        }

        //btn thoát
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            this.Close();
        }
    }
    
}