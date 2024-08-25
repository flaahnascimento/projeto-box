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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btncalcule_Click(object sender, EventArgs e)
        {
           //botão calcular 
            double preco = 0;

           //
           preco = double.Parse(txtpizza.Text);


            //
            if (rbborda.Checked && rbrefri.Checked)
            {
                preco += 5;
            }
            else if (rbborda.Checked)
            {
                preco += 2;
        

    }
            else if (rbrefri.Checked)
                preco += 3;
    {
            //
            txtpizza.Text = preco.ToString("F");
} 

}
    }
}
