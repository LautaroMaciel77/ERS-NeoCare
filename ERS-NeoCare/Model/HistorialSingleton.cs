using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class HistorialSingleton
    {
     
            private static HistorialSingleton instance;

            public HistorialModel historialAutenticado { get; private set; }
            public List<HistorialModel> historialesAutenticados;
        private HistorialSingleton()
            {

            }

            public static HistorialSingleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new HistorialSingleton();
                    }
                    return instance;
                }

            }
            public void AutenticarHistorial(HistorialModel archivos)
            {
            historialAutenticado = archivos;
            }
            public void AutenticarHistoriales(List<HistorialModel> archivos)
            {
                  historialesAutenticados = archivos;
            }
            public void DesuatenticarHistorial()
            {
                historialAutenticado = null;
            }
            public void DesuatenticarHistoriales()
            {
                    historialesAutenticados = null;
            }


    }
    
}
