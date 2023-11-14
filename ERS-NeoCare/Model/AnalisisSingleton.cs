using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class AnalisisSingleton
    {
        private static AnalisisSingleton instance;

        public AnalisisModel AnalisisAutenticado { get; private set; }
        private AnalisisSingleton()
        {

        }


        public static AnalisisSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnalisisSingleton();
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

