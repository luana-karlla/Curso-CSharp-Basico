using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length==3)
            {
                /*listCaixa.Items.Add(txtCodigo.Text);
                txtCodigo.Text = "";
                txtCodigo.Focus();*/

                int indice = 0;
                for(int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text==codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice==0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    listCaixa.Items.Add(txtCodigo.Text + "---" + produtos[indice] + "--R$" + valor[indice]);
                    soma = soma+valor[indice];
                    label1.Text = ("Valor total R$ " + soma);
                    picImagem.ImageLocation = "D:/MeusProjetos/Curso CSharp Básico-Fundação Bradesco/Curso-CSharp-Basico/Curso Csharp Basico/Sistema_Cantina/Imagem" + codigo[indice] + ".jpeg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus(); 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarArray();
            soma = 0;
        }
        private void CarregarArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chololate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
        }
    }
}
