namespace Ejercicio11U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha seleccionada: " +
                dateTimePicker1.Value.ToShortDateString();
        }
    }
}
