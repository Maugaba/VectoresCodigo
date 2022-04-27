namespace VectoresCodigo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verificar_Codigo verificar_Codigo = new Verificar_Codigo();
            verificar_Codigo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Generar_Codigo generar_Codigo = new Generar_Codigo();
            generar_Codigo.Show();
        }
    }
}