using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class AnalisisSingleton
    {
        private static AnalisisModel instance;
     
        public AnalisisModel AnalisisAutenticado { get; private set; }
        private AnalisisSingleton()
        {

        }

        public static AnalisisModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnalisisModel();
                }
                return instance;
            }

        }
        public void AutenticarAnalisis(AnalisisModel archivos)
        {
            AnalisisAutenticado = archivos;
        }
        public void DesautenticarAnalisis()
        {
            AnalisisAutenticado = null;
        }

    }
}

