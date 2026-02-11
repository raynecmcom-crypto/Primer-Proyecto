namespace Ejercicio8U2
{
    public partial class Form1 : Form
    {
        int contador = 0;
    
        public Form1()
        {
            InitializeComponent();
            lblConteo.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            lblConteo.Text = contador.ToString();
        }
    }
}
