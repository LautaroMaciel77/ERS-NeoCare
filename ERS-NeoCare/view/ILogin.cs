using ERS_NeoCare.Model;

namespace ERS_NeoCare.Design
{
    internal interface ILogin
    {

        string NombreUsuario { get; }
        string Contraseña { get; }
        void MostrarMensajeError(string mensaje);
        void MostrarMenu( );

    }
}
