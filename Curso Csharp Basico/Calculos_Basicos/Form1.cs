using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_Basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNume1.Text = ""; //fara com que o campo seja limpo ao clicar no bt limpar
            txtNume2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNume1.Text);
            num2 = Convert.ToDouble(txtNume2.Text);
            resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNume1.Text);
            num2 = Convert.ToDouble(txtNume2.Text);
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNume1.Text);
            num2 = Convert.ToDouble(txtNume2.Text);
            resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNume1.Text);
            num2 = Convert.ToDouble(txtNume2.Text);
            resultado = num1 / num2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
