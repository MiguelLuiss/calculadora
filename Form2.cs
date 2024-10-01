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
    public partial class Form2 : Form
    {
        float valor1 = 0;
        string operacao = "";
        float resultado = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            textVisor.Text = textVisor.Text + "1";


        }

        private void numero2_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("2");

        }

        private void numero3_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("3");
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("4");
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("5");
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("6");
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("7");
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("8");
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("9");
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            textVisor.AppendText("0");
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textVisor.Text);

            operacao = "adição";
            textVisor.Clear();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textVisor.Text);

            operacao = "divisão";
            textVisor.Clear();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textVisor.Text);

            operacao = "multiplicação";
            textVisor.Clear();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            textVisor.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.operacao == "adição")
            {
                float resultado = valor1 + Convert.ToSingle(textVisor.Text);
                textVisor.Text = Convert.ToString(resultado);
            }

            if (this.operacao == "multiplicação")
            {
                float resultado = valor1 * Convert.ToSingle(textVisor.Text);
                textVisor.Text = Convert.ToString(resultado);
            }

            if (this.operacao == "divisão")
            {
                float resultado = valor1 / Convert.ToSingle(textVisor.Text);
                textVisor.Text = Convert.ToString(resultado);
            }
        }

        private void menuConversor_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuConversor_Click(object sender, EventArgs e)
        {

        }

        private void cParaFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmParaPolegadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversor Conversor = new conversor();
            Conversor.ShowDialog();
        }
    }
}
