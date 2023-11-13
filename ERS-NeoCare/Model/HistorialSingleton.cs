using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class HistorialSingleton
    {
     
            private static HistorialModel instance;

            public HistorialModel historialAutenticado { get; private set; }
            private HistorialSingleton()
            {

            }

            public static HistorialModel Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new HistorialModel();
                    }
                    return instance;
                }

            }
            public void AutenticarHistorial(HistorialModel archivos)
            {
            historialAutenticado = archivos;
            }
            public void DesautenticarAnalisis()
            {
            historialAutenticado = null;
            }

        }
    
}
