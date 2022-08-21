using Compilador.Clases;
namespace Compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anLex analizador = new anLex();
            analizador.analizar(textBox1.Text);
            dataGridView1.DataSource = analizador.lexemas;
        }
    }
}