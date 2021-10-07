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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            switch (CboOpcao.Text)
            {
                case "1 ou 2":
                    
                        lblRes.Text = "O dia de seu rodizio é segunda-feira";
                        break;
                   
                case "3 ou 4":
                  
                        lblRes.Text = "O dia de seu rodizio é terça-feira";
                        break;
                   
                case "5 ou 6":
                   
                        lblRes.Text = "O dia de seu rodizio é quarta-feira";
                        break;
                   
                case "7 ou 8":
                   
                        lblRes.Text = "O dia de seu rodizio é quinta-feira";
                        break;
                   
                case "9 ou 0":
                  
                        lblRes.Text = "O dia de seu rodizio é sexta-feira";
                        break;

                   
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();

            this.Visible = false;
        }

        private void LblRes_Click(object sender, EventArgs e)
        {

        }
    }
}
