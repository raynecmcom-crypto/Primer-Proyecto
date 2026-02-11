namespace Ejercicio9U2
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
            txtNumero = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(86, 126);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(139, 29);
            txtNumero.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Poor Richard", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.Location = new Point(246, 126);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 29);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Aceptar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(472, 266);
            Controls.Add(btnValidar);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnValidar;
    }
}
