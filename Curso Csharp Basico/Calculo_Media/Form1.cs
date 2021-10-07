using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        double n1, n2, n3, media;

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textnota1.Text = "";
            textNota2.Text = "";
            textNota3.Text = "";
            textMedia.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textnota1.Text);
            n2 = Convert.ToDouble(textNota2.Text);
            n3 = Convert.ToDouble(textNota3.Text);
            media = (n1*5 + n2*3 + n3*2) / 10;
            textMedia.Text = media.ToString();

            if(media >= 7)
            {
                MessageBox.Show("Aluno Aprovado!");
            }
            else if(media < 5)
            {
                MessageBox.Show("Aluno Reprovado!");
            }
            else 
            {
                MessageBox.Show("Aluno em Recuperação!");
            }

        }
    }
}
