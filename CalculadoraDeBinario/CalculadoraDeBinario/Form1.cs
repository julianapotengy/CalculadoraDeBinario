using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string valorBinario = Conversao.DecimalParaBinario(textBox1.Text);
                textBox2.Text = valorBinario;

                string valorHex = Conversao.DecimalParaHex(int.Parse(textBox1.Text));
                textBox3.Text = valorHex;
            }
            catch(Exception)
            {
                textBox2.Text = "Tente novamente";
                textBox3.Text = "Tente novamente";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valorDecimal = Conversao.BinarioParaDecimal(textBox2.Text);
                textBox1.Text = Convert.ToString(valorDecimal);

                string valorHex = Conversao.BinarioParaHex(textBox2.Text);
                textBox3.Text = valorHex;
            }
            catch(Exception)
            {
                textBox1.Text = "Tente novamente";
                textBox3.Text = "Tente novamente";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valorBinario = Conversao.HexParaBinario(textBox3.Text);
            textBox2.Text = valorBinario;

            string valorDecimal = Conversao.HexParaDecimal(textBox3.Text);
            textBox1.Text = valorDecimal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
