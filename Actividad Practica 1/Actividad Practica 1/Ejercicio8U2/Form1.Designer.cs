namespace Ejercicio8U2
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
            lblConteo = new Label();
            btnContar = new Button();
            SuspendLayout();
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.BackColor = Color.White;
            lblConteo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConteo.ForeColor = Color.Black;
            lblConteo.Location = new Point(213, 120);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(57, 21);
            lblConteo.TabIndex = 0;
            lblConteo.Text = "label1";
            lblConteo.Click += label1_Click;
            // 
            // btnContar
            // 
            btnContar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContar.Location = new Point(46, 115);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(75, 30);
            btnContar.TabIndex = 1;
            btnContar.Text = "button1";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(471, 247);
            Controls.Add(btnContar);
            Controls.Add(lblConteo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConteo;
        private Button btnContar;
    }
}
