using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class TurnoSingleton
    {
        private static TurnoSingleton instance;
        public Turno TurnoAutenticado { get; private set; }

        private TurnoSingleton()
        {
            // Puedes agregar cualquier lógica de inicialización necesaria aquí
        }

        public static TurnoSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TurnoSingleton();
                }
                return instance;
            }
        }

        public void AutenticarTurno(Turno turno)
        {
            TurnoAutenticado = turno;
        }

        public void DesautenticarTurno()
        {
            TurnoAutenticado = null;
        }
    }
}
