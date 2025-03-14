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
    public partial class F_ListBox: Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }
        public void AttDataSource(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um valor válido");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                AttDataSource(lb_carros, carros);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            AttDataSource(lb_carros, carros);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }
    }
}
