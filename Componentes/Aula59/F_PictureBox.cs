using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula59
{
    public partial class F_PictureBox: Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        { 
            label1.Text = Properties.Resources.Nome;
            label2.Text = Properties.Resources.EndereçoYoutube;
        }

        private void btn_img1_Click(object sender, EventArgs e)
        {
            pb_imgs.Image = Properties.Resources.velho;
        }

        private void btn_img2_Click(object sender, EventArgs e)
        {
            pb_imgs.Image = Properties.Resources.snoopy;
        }
    }
}
