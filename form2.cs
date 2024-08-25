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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void btncalcul_Click(object sender, EventArgs e)
        {
            //botão calcular 2 clicks

            // variável Double - real
            double n1, n2, total = 0;

            //entradas variável n1 recebe conversão para (nome do componente. Text)

            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);

            switch (cboperac.SelectedIndex)

            {

                case 0:
                    total = n1 + n2;
                    break;

                case 1:

                    total = n1 - n2;
                    break;

                case 2:
                    total = n1 / n2;
                    break;

                case 3:
                    total = n1 * n2;
                    break;

            }
            //exibir o total nome do componente.Text = total.ToString();
            txtresult.Text = total.ToString();

        }
    }
}
