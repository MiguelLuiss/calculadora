namespace calculadora
{
    partial class Testes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbrsplash = new ProgressBar();
            tmr_progressBar1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pbrsplash
            // 
            pbrsplash.Location = new Point(179, 26);
            pbrsplash.Name = "pbrsplash";
            pbrsplash.Size = new Size(364, 42);
            pbrsplash.Style = ProgressBarStyle.Continuous;
            pbrsplash.TabIndex = 0;
            pbrsplash.Value = 2;
            pbrsplash.Click += pbrsplash_Click;
            // 
            // Testes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbrsplash);
            Name = "Testes";
            Text = "Testes";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar pbrsplash;
        private System.Windows.Forms.Timer tmr_progressBar1;
    }
}