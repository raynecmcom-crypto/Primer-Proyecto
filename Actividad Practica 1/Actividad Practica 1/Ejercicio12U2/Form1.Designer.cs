namespace Ejercicio12U2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCelsius = new TextBox();
            bntConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(239, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese temperatura a Celsius:";
            // 
            // txtCelsius
            // 
            txtCelsius.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCelsius.Location = new Point(272, 29);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(209, 27);
            txtCelsius.TabIndex = 1;
            // 
            // bntConvertir
            // 
            bntConvertir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntConvertir.Location = new Point(396, 81);
            bntConvertir.Name = "bntConvertir";
            bntConvertir.Size = new Size(85, 33);
            bntConvertir.TabIndex = 2;
            bntConvertir.Text = "Convertir";
            bntConvertir.UseVisualStyleBackColor = true;
            bntConvertir.Click += bntConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(499, 35);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 21);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(718, 217);
            Controls.Add(lblResultado);
            Controls.Add(bntConvertir);
            Controls.Add(txtCelsius);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelsius;
        private Button bntConvertir;
        private Label lblResultado;
    }
}
