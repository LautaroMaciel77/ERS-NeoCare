using ERS_NeoCare.Design;
using ERS_NeoCare.Model;

namespace ERS_NeoCare.Logic
{
    internal class LoginPresenter
    {

        private ILogin _view;
        private UsuarioService _usuarioService;

        public LoginPresenter(ILogin view, UsuarioService usuarioService)
        {
            _view = view;
            _usuarioService = usuarioService;
        }

        public void IniciarSesion()
        {
            string nombreUsuario = _view.NombreUsuario;
            string contraseña = _view.Contraseña;

            UsuarioModel usuario = _usuarioService.Authenticate(nombreUsuario, contraseña);

            if (usuario != null)
            {
                _view.MostrarMenu(usuario);
            }
            else
            {
                _view.MostrarMensajeError("Credenciales incorrectas. Inténtalo de nuevo.");
            }
        }
    }
}

