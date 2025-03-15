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
    public partial class F_TextMask: Form
    {
        public F_TextMask()
        {
            InitializeComponent();
        }

        private void btn_cpf_Click(object sender, EventArgs e)
        {
            if (cb_texto.Checked)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
                string msg = mtb_cpf.Text;
            MessageBox.Show(msg);
        }

        private void cb_texto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(mtb_password.PasswordChar == '*')
            {
                mtb_password.PasswordChar = '\0' ;
            }
            else
            {
                mtb_password.PasswordChar = '*';
            }
        }
    }
}
