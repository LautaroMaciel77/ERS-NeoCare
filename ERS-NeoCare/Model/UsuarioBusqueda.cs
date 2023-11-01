using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class UsuarioBusqueda
    {
        private static UsuarioBusqueda instance;
        public UsuarioModel UsuarioAutenticado { get; private set; }

        private UsuarioBusqueda() { }

        public static UsuarioBusqueda Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsuarioBusqueda();
                }
                return instance;
            }
        }
        public void AutenticarUsuario(UsuarioModel usuario)
        {
            UsuarioAutenticado = usuario;
        }
        public void DesautenticarUsuario()
        {
            UsuarioAutenticado = null;
        }

    }
}

