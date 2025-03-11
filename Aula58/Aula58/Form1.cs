using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula58
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            lb_text.Text = tb_text.Text;
        }

        private void lb_text_Click(object sender, EventArgs e)
        {

        }
    }
}
