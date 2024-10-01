namespace calculadora
{
    partial class conversor
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
            txtCm = new TextBox();
            label1 = new Label();
            Converter = new Button();
            textBox1 = new TextBox();
            Resultado = new Label();
            SuspendLayout();
            // 
            // txtCm
            // 
            txtCm.Location = new Point(201, 75);
            txtCm.Multiline = true;
            txtCm.Name = "txtCm";
            txtCm.Size = new Size(410, 51);
            txtCm.TabIndex = 0;
            txtCm.TextChanged += txtCm_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(201, 29);
            label1.Name = "label1";
            label1.Size = new Size(410, 31);
            label1.TabIndex = 1;
            label1.Text = "Insira o valor em centimetros abaixo:";
            label1.Click += label1_Click;
            // 
            // Converter
            // 
            Converter.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Converter.Location = new Point(265, 151);
            Converter.Name = "Converter";
            Converter.Size = new Size(276, 82);
            Converter.TabIndex = 2;
            Converter.Text = "Converter";
            Converter.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 339);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 52);
            textBox1.TabIndex = 3;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.BackColor = SystemColors.ButtonHighlight;
            Resultado.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resultado.ForeColor = SystemColors.ActiveCaptionText;
            Resultado.Location = new Point(327, 287);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(146, 38);
            Resultado.TabIndex = 4;
            Resultado.Text = "Resultado";
            // 
            // conversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 455);
            Controls.Add(Resultado);
            Controls.Add(textBox1);
            Controls.Add(Converter);
            Controls.Add(label1);
            Controls.Add(txtCm);
            Margin = new Padding(2, 2, 2, 2);
            Name = "conversor";
            Text = "conversor";
            Load += conversor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCm;
        private Label label1;
        private Button Converter;
        private TextBox textBox1;
        private Label Resultado;
    }
}