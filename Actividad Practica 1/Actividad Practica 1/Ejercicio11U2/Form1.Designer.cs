namespace Ejercicio11U2
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
            btnMostrar = new Button();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(256, 72);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Aceptar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.Menu;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(12, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(159, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha Seleccionada";
            lblFecha.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(12, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(523, 241);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
    }
}
