using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu domingo o primeiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu segunda o segundo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu terça o terceiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu quarta o quarto dia da semana", "Mensagem", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu quinta o quinto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu sexta o sexto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sábado":
                    MessageBox.Show("Você escolheu sábado o sétimo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void BtnProximoExemplo_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();

            this.Visible = false;
        }
    }
}
