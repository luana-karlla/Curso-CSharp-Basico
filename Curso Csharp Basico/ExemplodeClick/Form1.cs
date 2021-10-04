using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplodeClick
{
    public partial class Form1 : Form
    {
        string nome;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntClick_Click(object sender, EventArgs e)
        {
            nome = "Ola, Seja Bem vindo(a) em meu sistema";
            textName.Text = nome;
            Console.ReadLine();
        }
    }
}
