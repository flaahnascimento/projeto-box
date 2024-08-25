using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbutton_Click(object sender, EventArgs e)
        {

        }

        private void btnVerifiq_Click(object sender, EventArgs e)
        {
            //click 2 vezes no botão verificar

            // variável 
            string cor;

            //entrada 
            // cor = nome do componente que escreve a cor.Text.ToUpper();

            cor = txtcor.Text.ToUpper();

            switch (cor)
            {
                case "VERDE":
                    MessageBox.Show("Você digitou VERDE");
                    break;

                case "AZUL":
                    MessageBox.Show("Você digitou AZUL");
                    break;

                case "AMARELO":
                    MessageBox.Show("Você digitou AMARELO");
                    break;

                default:
                    MessageBox.Show("Não consegui descobrir");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
  
}
