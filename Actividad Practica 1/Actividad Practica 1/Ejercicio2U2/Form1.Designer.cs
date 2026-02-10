namespace Ejercicio2U2
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
            TextoACambiar = new Label();
            CambiarTex = new Button();
            SuspendLayout();
            // 
            // TextoACambiar
            // 
            TextoACambiar.AutoSize = true;
            TextoACambiar.ForeColor = SystemColors.ControlLightLight;
            TextoACambiar.Location = new Point(425, 133);
            TextoACambiar.Margin = new Padding(9, 0, 9, 0);
            TextoACambiar.Name = "TextoACambiar";
            TextoACambiar.Size = new Size(111, 39);
            TextoACambiar.TabIndex = 0;
            TextoACambiar.Text = "Texto...";
            // 
            // CambiarTex
            // 
            CambiarTex.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CambiarTex.Location = new Point(71, 125);
            CambiarTex.Margin = new Padding(9, 9, 9, 9);
            CambiarTex.Name = "CambiarTex";
            CambiarTex.Size = new Size(250, 47);
            CambiarTex.TabIndex = 1;
            CambiarTex.Text = "Cambiar texto";
            CambiarTex.UseVisualStyleBackColor = true;
            CambiarTex.Click += CambiarTex_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(734, 322);
            Controls.Add(CambiarTex);
            Controls.Add(TextoACambiar);
            Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(9, 9, 9, 9);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextoACambiar;
        private Button CambiarTex;
    }
}
