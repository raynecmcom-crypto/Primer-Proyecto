namespace Ejercicio5U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Seleccionaste: Opcion 1";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Seleccionate: Opcion 2";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Seleccionate: Opcion 3";
            }
            else
            {
                label1.Text = "No seleccionate ninguna opcicon";
            }
        }
    }
}
   

    
