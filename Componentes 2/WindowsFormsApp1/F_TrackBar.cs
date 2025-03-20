using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class F_TrackBar: Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < trackBar1.Minimum) 
            {
                MessageBox.Show("Valor abaixo do minimo");
                return;
            }
            else if (int.Parse(textBox1.Text) > trackBar1.Maximum)
            {
                MessageBox.Show("Valor acima do máximo");
                return ;
            }
            trackBar1.Value = int.Parse(textBox1.Text);
        }

        private void F_TrackBar_Load(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
