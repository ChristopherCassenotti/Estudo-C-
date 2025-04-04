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
    public partial class F_RadioButton: Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void F_RadioButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt;

            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            MessageBox.Show(txt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt="";

            foreach (RadioButton radio in groupBox1.Controls)
            {
                if (radio.Checked)
                {
                    txt = radio.Text;
                }
            }
            MessageBox.Show(txt);
        }
    }
}
