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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //botao estado escolha

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //proc no botão selected do comboxx
            //sp

            if (cbestado.SelectedIndex == 0)
            {
                cbcidade.Items.Clear();
                cbcidade.Items.Add("Ferraz de Vasconcelos");
                cbcidade.Items.Add("poá");
            }
            //rj
            else if (cbestado.SelectedIndex == 1)
            {
                cbcidade.Items.Clear();
                cbcidade.Items.Add("niteroi");
                cbcidade.Items.Add("nova iguaçu");
            }
            //salvador
            else if (cbestado.SelectedIndex == 2)
            {
                cbcidade.Items.Clear();
                cbcidade.Items.Add("itaparica");
                cbcidade.Items.Add("vera cruz");
            }

           
        }
        // botao escolha 2 clicks
        private void btnescolha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("estado escolhido: " + cbestado.SelectedItem + "\ncidade: " + cbcidade.SelectedItem);

        }
    }
}
