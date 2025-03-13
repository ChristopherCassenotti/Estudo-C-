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
    public partial class F_DateTimePicker: Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_getDay_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;

            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
        }

        private void btn_setDay_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(tb_dia.Text);
            m = Int32.Parse(tb_mes.Text);
            a = Int32.Parse(tb_ano.Text);

            DateTime dt = new DateTime(a, m, d);

            dtp_data.Value = dt;
        }

        private void btn_today_Click(object sender, EventArgs e)
        { 
            dtp_data.Value = DateTime.Today;
        }
    }
}
