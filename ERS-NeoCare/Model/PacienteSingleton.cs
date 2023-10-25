using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class PacienteSingleton
    {
        private static PacienteSingleton instance;
        public PacienteModel pacienteAutenticado { get; private set; }

        private PacienteSingleton() { }

        public static PacienteSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacienteSingleton();
                }
                return instance;
            }
        }
        public void Autenticar(PacienteModel paciente)
        {
            pacienteAutenticado = paciente;
        }
        public void Desautenticar()
        {
            pacienteAutenticado = null;
        }
    }
}
