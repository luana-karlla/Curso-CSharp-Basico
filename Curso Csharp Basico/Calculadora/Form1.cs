using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResultado.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 * num2;
            textResultado.Text = resultado.ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 / num2;
            textResultado.Text = resultado.ToString();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 + num2;
            textResultado.Text = resultado.ToString();

        }
        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 - num2;
            textResultado.Text = resultado.ToString();
        }
    }
}
