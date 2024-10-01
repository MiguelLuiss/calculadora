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
    public partial class conversor : Form
    {
        double valor1 = 0;
        float oprconversor = 0;
        double resultado = 0;

        public conversor()
        {
            InitializeComponent();
        }

        private void conversor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCm_TextChanged(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtCm.Text);
            double resultado = valor1 /2.54;
            textBox1.Text = Convert.ToString(resultado);
        }
    }
}
