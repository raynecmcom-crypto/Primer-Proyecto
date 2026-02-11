namespace Ejercicio9U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Es un número válido");
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar un número");
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }

     
    }
}
