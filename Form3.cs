using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{

    public partial class Form3 : Form
    {
        double valor1 = 0;
        float oprconversor = -10;
        double resultado = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtConversor.Text);
            double resultado = valor1 * 1.8 + 32;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void txtConversor_TextChanged(object sender, EventArgs e)
        {


        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtConversor.Clear();
            txtResultado.Clear();
            valor1 = 0;
            resultado = 0;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
