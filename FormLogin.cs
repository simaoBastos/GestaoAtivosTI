using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoAtivosTI
{
    public partial class FormLogin : Form
    {
        private bool _hidePass = true;
        public FormLogin()
        {
            InitializeComponent();
            btnHidePass.Text = "\u25CF";
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                this.Hide();
                var telaPrincipal = new FormPrincipal();

                telaPrincipal.FormClosed += (s, args) => this.Close();
                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            _hidePass = !_hidePass;
            if (_hidePass)
            {
                btnHidePass.Text = "\u25CF";
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                btnHidePass.Text = "\u25CB";
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
