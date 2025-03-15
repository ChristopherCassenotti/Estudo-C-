using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void OpenForm<T>()where T : Form, new()
            {
            T form = new T();
            form.Show();
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
            OpenForm<F_CheckBox>();
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<F_CheckListBox>();
        }

        private void componetesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<F_ComboBox>();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<F_DateTimePicker>();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<F_CheckBox>();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<F_ListBox>();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<F_ListView>();
        }
    }
}
