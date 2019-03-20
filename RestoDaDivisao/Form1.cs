using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //No Botao para Resolver a Divisão
        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int resto = dividendo % divisor;
            txtResto.Text = resto.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Para nao aumentar o Form
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
