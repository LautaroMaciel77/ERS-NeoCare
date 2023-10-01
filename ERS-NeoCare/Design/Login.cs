using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class Login : Form, ILogin
    {
        private LoginPresenter _presenter;

        public Login()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, new UsuarioService(Configuracion.ConnectionString));
        }

        public string NombreUsuario => textBoxUser.Text;
        public string Contraseña => textBoxPass.Text;

        public void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void MostrarMenu(UsuarioModel usuario)
        {
            textBoxUser.Text = string.Empty;
            textBoxPass.Text = string.Empty;
            menu homeForm = new menu(usuario);
            homeForm.Show();
        }

        private void iconButtonIniciar_Click(object sender, EventArgs e)
        {
            _presenter.IniciarSesion();
        }
    }


}

