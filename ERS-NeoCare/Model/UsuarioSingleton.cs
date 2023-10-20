using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    public class UsuarioSingleton
    {
        private static UsuarioSingleton instance;
        public UsuarioModel UsuarioAutenticado { get; private set; }

        private UsuarioSingleton() { }

        public static UsuarioSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsuarioSingleton();
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
