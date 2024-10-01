namespace calculadora
{
    partial class Form3
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
            button1 = new Button();
            txtConversor = new TextBox();
            label1 = new Label();
            txtResultado = new TextBox();
            clear = new Button();
            Sair = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(307, 155);
            button1.Name = "button1";
            button1.Size = new Size(142, 71);
            button1.TabIndex = 0;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtConversor
            // 
            txtConversor.Location = new Point(149, 60);
            txtConversor.Multiline = true;
            txtConversor.Name = "txtConversor";
            txtConversor.Size = new Size(464, 71);
            txtConversor.TabIndex = 1;
            txtConversor.TextChanged += txtConversor_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 48);
            label1.TabIndex = 2;
            label1.Text = "Digite o valor";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(187, 265);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(404, 78);
            txtResultado.TabIndex = 3;
            // 
            // clear
            // 
            clear.Location = new Point(638, 159);
            clear.Name = "clear";
            clear.Size = new Size(130, 67);
            clear.TabIndex = 4;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Sair
            // 
            Sair.Location = new Point(665, 361);
            Sair.Name = "Sair";
            Sair.Size = new Size(123, 77);
            Sair.TabIndex = 5;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(Sair);
            Controls.Add(clear);
            Controls.Add(txtResultado);
            Controls.Add(label1);
            Controls.Add(txtConversor);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtConversor;
        private Label label1;
        private TextBox txtResultado;
        private Button clear;
        private Button Sair;
    }
}