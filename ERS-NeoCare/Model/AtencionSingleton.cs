using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class AtencionSingleton
    {
        private static AtencionSingleton instance;

        public AtencionEnfermeriaModel AtencionAutenticada { get; private set; }
        private AtencionSingleton()
        {

        }

        public static AtencionSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AtencionSingleton();
                }
                return instance;
            }

        }
        public void Autenticar(AtencionEnfermeriaModel archivos)
        {
            AtencionAutenticada = archivos;
        }
        public void DesautenticarAnalisis()
        {
            AtencionAutenticada = null;
        }
    }
}

