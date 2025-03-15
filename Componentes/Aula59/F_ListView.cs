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
    public partial class F_ListView: Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qntd.Clear();
            tb_preco.Clear();
        }
        private void Obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qntd.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qntd.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem (pr);
            lv_produtos.Items.Add (l);
            Limpar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            Obter();
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedItems.Count > 0)
            {
                Obter();
            }
        }
    }
}
