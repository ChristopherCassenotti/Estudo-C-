﻿using System;
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
    public partial class F_NumericUpDown: Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_setValue_Click(object sender, EventArgs e)
        {
            if (Decimal.Parse(tb_setValue.Text) >= nud_value.Minimum & Decimal.Parse(tb_setValue.Text) <= nud_value.Maximum)
            {
                nud_value.Value = Decimal.Parse(tb_setValue.Text);
            }
        }
    }
}
