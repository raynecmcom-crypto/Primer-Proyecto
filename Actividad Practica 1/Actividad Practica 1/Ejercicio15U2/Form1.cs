namespace Ejercicio15U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (.txt)|.txt|Todos los archivos (.)|.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtContenido.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtContenido.Text);
                MessageBox.Show("Archivo guardado correctamente.");
            }
        
        }
    }
}
