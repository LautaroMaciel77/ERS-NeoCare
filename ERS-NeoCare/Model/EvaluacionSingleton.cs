using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class EvaluacionSingleton
    {
      
            private static EvaluacionSingleton instance;

            public EvaluacionModel evaluacionAutenticada { get; private set; }
            private EvaluacionSingleton()
            {

            }

            public static EvaluacionSingleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new EvaluacionSingleton();
                    }
                    return instance;
                }

            }
            public void Autenticar(EvaluacionModel archivos)
            {
            evaluacionAutenticada = archivos;
            }
            public void DesautenticarAnalisis()
            {
            evaluacionAutenticada = null;
            }
        }
    
}
