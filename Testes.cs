using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora
{
    public partial class Testes : Form
    {
        public Testes()
        {
            InitializeComponent();
        }

        private void pbrsplash_Click(object sender, EventArgs e)
        {
            pbrsplash.Value = pbrsplash.Value + 1;
            if (pbrsplash.Value == 100)
            {
                tmr_progressBar1.Enabled = false;
                this.Hide();
                Teste2 teste2 = new Teste2();
                teste2.ShowDialog();
            }
        }
    }
}
