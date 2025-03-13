using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula59
{
    public partial class F_ComboBox: Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_showSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Moto");
            tr.Add("Avião");
            tr.Add("Skate");
            tr.Add("Trem");
            cb_transportes.Items.AddRange(tr.ToArray());
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_trasporte.Text = cb_transportes.Text;
        }

        private void btn_add_new_trasp_Click(object sender, EventArgs e)
        {
            if (tb_trasporte.Text != "")
            {
                if(cb_transportes.FindString(tb_trasporte.Text) < 0) 
                {
                    cb_transportes.Items.Add(tb_trasporte.Text);
                    return;
                }
                
            }
        }
    }
}
