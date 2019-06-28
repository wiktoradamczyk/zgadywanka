using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;

        }

        private void btnNowaGra_Click(object sender, EventArgs e)
        {
            grpBoxLosowanie.Visible = true;
            btnNowaGra.Enabled = false;
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            // todo: try-catch
            int a = int.Parse(textBoxOd.Text);
            int b = int.Parse(textBoxDo.Text);
            g = new Gra(a, b);

            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            btnLosuj.Enabled = false;
            groupBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gra.Odpowiedz odpowiedz;
           odpowiedz = g.Ocena(int.Parse(textBox1.Text));
          

            switch (odpowiedz)
            {
                case Gra.Odpowiedz.ZaDuzo:
                    label2.Text = "Za dużo";
                    break;
                case Gra.Odpowiedz.ZaMalo:
                    label2.Text = "Za mało";
                    break;
                case Gra.Odpowiedz.Trafiono:
                    label2.Text = "Trafiono";
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
