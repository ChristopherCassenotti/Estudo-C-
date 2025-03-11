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
    public partial class Aula59: Form
    {
        public Aula59()
        {
            InitializeComponent();
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
    }
}
