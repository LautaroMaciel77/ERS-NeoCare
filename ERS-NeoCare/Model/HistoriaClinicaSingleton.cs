using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class HistoriaClinicaSingleton
    {
        private static HistoriaClinicaSingleton instance;
        public HistoriaClinicaModel historiaAutenticado { get; private set; }

        private HistoriaClinicaSingleton() { }

        public static HistoriaClinicaSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HistoriaClinicaSingleton();
                }
                return instance;
            }
        }
        public void Autenticarhistoria(HistoriaClinicaModel historia)
        {
            historiaAutenticado = historia;
        }
        public void Desautenticarhistoria()
        {
            historiaAutenticado = null;
        }

    }
}

