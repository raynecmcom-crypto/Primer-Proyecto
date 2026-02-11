namespace Ejercicio12U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntConvertir_Click(object sender, EventArgs e)
        {
            double celsius;

            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = "Resultado: " + fahrenheit.ToString("0.00") + " °F";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtCelsius.Clear();
                txtCelsius.Focus();
            }
        }
    }
 
}
