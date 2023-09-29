using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    public class UsuarioModel
    {
        public int Matricula { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int ProfesionID { get; set; }
        public string Password { get; set; }
    }
}
