using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class OrdenSingleton
    {
        private static OrdenSingleton instance;
        public OrdenModel OrdenAutenticada { get; private set; }

        private OrdenSingleton() { }

        public static OrdenSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrdenSingleton();
                }
                return instance;
            }
        }
        public void Autenticar(OrdenModel orden)
        {
            OrdenAutenticada = orden;
        }
        public void Desautenticar()
        {
            OrdenAutenticada = null;
        }
    }
}
