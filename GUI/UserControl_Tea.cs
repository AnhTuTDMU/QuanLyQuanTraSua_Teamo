using System;
using System.Drawing;

namespace GUI
{
    public partial class UserControl_Tea : System.Windows.Forms.UserControl
    {
        public event EventHandler Onselect = null;

        public UserControl_Tea()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
          
        }
        

        public string Title { get => lbl_Title.Text; set => lbl_Title.Text = value; }

        public string Gia { get => lbl_Gia.Text; set => lbl_Gia.Text = value;}

        public Image icon { get => pictureBox1.Image; set =>pictureBox1.Image = value; }

       
    }
}
