namespace SistemaAcademiaProgramador.WinApp
{
    public partial class TelaLogin : Form
    {
        public TelaLogin() 
        {
            InitializeComponent();
        }

        private void TelaLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "olá mundo!", 
                "Seja bem-vindo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
