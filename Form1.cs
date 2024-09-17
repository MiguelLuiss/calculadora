namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tmr_progressbar_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == 100)
            {
                tmr_progressbar.Enabled = false;
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                
            }

            
        }
    }
}
