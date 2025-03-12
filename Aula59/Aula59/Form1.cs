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
    public partial class F_Principal: Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veículo");
                txt_veiculo.Focus();
                return;
            }

            txt_mult_veiculo.Text += txt_veiculo.Text + ", ";


            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_mult_veiculo.Clear();
            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }

        private void list_veiculo_Click(object sender, EventArgs e)
        {
            List<string> veiculos = new List<string>();
            veiculos.Add(txt_mult_veiculo.Text);
            foreach (string v in veiculos)

            MessageBox.Show(v);
        }

        private void btn_showV_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(txt_mult_veiculo.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckListBox f_CheckListBox = new F_CheckListBox();
            f_CheckListBox.ShowDialog();
        }

        private void componetesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
