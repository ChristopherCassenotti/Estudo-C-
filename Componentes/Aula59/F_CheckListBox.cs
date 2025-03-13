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
    public partial class F_CheckListBox: Form
    {
        public F_CheckListBox()
        {
            InitializeComponent();
        }

        private void btn_showSelect_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            

            MessageBox.Show(txt);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");
            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_inputItem_Click(object sender, EventArgs e)
        {
            if(tb_newTransp.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                return;
            }
            clb_transportes.Items.Add(tb_newTransp.Text);
        }
    }
}
