using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class ArchivoEstudiosSingleton
    {

        private static Model.ArchivoEstudiosSingleton instance;
        public List<ArchivoEstudio> archivosEstudio { get; private set; }

        private ArchivoEstudiosSingleton()
        {
       
        }

        public static Model.ArchivoEstudiosSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Model.ArchivoEstudiosSingleton();
                }
                return instance;
            }

        }
        public void AutenticarArchivos(List<ArchivoEstudio> archivos)
        {
            archivosEstudio = archivos;
        }
    }
}
