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
    public partial class F_LinkLabel: Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_mult.Links.Add(0,6 ,"www.google.com.br");
            ll_mult.Links.Add(9,11 ,"calc.exe");
            ll_mult.Links.Add(23,7 ,"http://youtube.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/");

            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            ll_calculadora.LinkVisited = true;
        }

        private void ll_mult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
