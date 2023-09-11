using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare
{
    internal class Paciente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string  Condicion { get; set; }

        public Paciente(string dni, string nombre, string apellido, DateTime fechaNacimiento, string condicion)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Condicion = condicion;
        }
    }

    

}
