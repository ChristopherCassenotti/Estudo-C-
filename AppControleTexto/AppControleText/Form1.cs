using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppControleText
{
    public partial class Editor_texto : Form
    {
        StreamReader leitura = null;

        public Editor_texto()
        {
            InitializeComponent();
        }
        private void NewText()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            NewText();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewText();
        }
        private void SaveText()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(arquivo);
                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.richTextBox1.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na hora de salvar" + ex.Message, " Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void OpenDocument()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\Chico\\Documents\\C#\\AppControleTexto";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(arquivo);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = streamReader.ReadLine();
                    while (linha != null) 
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = streamReader.ReadLine();
                    }
                    streamReader.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Erro na hora de abrir" + ex.Message, " Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Negrito()
        {
            string nomeFont = null;
            float tamanhoFont = 0.0f;
            bool n, i, s;

            nomeFont = richTextBox1.Font.Name;
            tamanhoFont = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Regular);
                }
            }
        }

        private void Italico()
        {
            string nomeFont = null;
            float tamanhoFont = 0.0f;
            bool n, i, s;

            nomeFont = richTextBox1.Font.Name;
            tamanhoFont = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic | FontStyle.Bold);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Regular);
                }
            }
        }

        private void Sublinhado()
        {
            string nomeFont = null;
            float tamanhoFont = 0.0f;
            bool n, i, s;

            nomeFont = richTextBox1.Font.Name;
            tamanhoFont = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Underline | FontStyle.Bold);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Bold);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFont, tamanhoFont, FontStyle.Regular);
                }
            }
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }
    }
}
