using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Imc
{

    public partial class Form1 : Form
    {
        double peso, altura, imc;

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            peso = Convert.ToDouble(textBox1.Text);
            altura = Convert.ToDouble(textBox2.Text);
            imc = peso/(altura * altura);
            textBox3.Text = imc.ToString("0.00");

            if (imc < 18.49)
            {
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso", "Calculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 24.99 )
            {
                MessageBox.Show("SITUAÇÃO: Você está com peso dentro da normalidade", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
            else if(imc < 29.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está acima do peso", "Cálculo IMC", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(imc < 34.99)
            {
                MessageBox.Show("SITUAÇÃO: Atenção! Você está com obesidade grau I", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (imc < 39.99)
            {
                MessageBox.Show("SITUAÇÃO: Atenção! Você está com obesidade grau II (severa) ", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Situação: Atenção! Você está com obesidade grau III (mórbida)", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
