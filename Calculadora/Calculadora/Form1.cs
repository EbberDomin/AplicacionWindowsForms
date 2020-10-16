using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero1.TextLength != 0 & txtNumero2.TextLength != 0)
            {
                lbResultado.Text = (int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text)).ToString();
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
            else
            {
                MessageBox.Show("Se encontro un error");
                txtNumero1.Text = "";

            }
        }
    }
}
