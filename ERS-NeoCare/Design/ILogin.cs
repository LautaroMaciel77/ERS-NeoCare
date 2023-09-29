using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Design
{
    internal interface ILogin
    {

        string NombreUsuario { get; }
        string Contraseña { get; }
        void MostrarMensajeError(string mensaje);
        void MostrarMenu(UsuarioModel usuario);

    }
}
