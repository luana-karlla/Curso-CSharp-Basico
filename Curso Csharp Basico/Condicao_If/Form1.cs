using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_If
{
    public partial class Form1 : Form
    {
        int idade;

        public Form1()
        {
            InitializeComponent();
        }

        private void VerificarIdade_Click(object sender, EventArgs e)
        {
            idade = Convert.ToInt32(textCaixa1.Text);
         
            if (idade>=18)
            {
                MessageBox.Show("Você é maior de idade!");
               
            }else
            {
                MessageBox.Show("Você é menor de idade");
            }
        }

        private void textCaixa1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
