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
    public partial class F_FilhoCheckBox: Form
    {
        public F_CheckBox fcb;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try
            {
                fcb = Application.OpenForms["F_CheckedListB"] as F_CheckBox;
                cb_carro.Checked = fcb.cb_carro.Checked;
                cb_moto.Checked = fcb.cb_moto.Checked;
                cb_navio.Checked = fcb.cb_navio.Checked;
                cb_onibus.Checked = fcb.cb_onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir o formulário");
            }
        }

        private void F_FilhoCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_carro.Checked = cb_carro.Checked;
        }
        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_navio.Checked = cb_navio.Checked;
        }
        private void cb_moto_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_moto.Checked = cb_moto.Checked;
        }
        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
