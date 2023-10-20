using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Presenter
{
    internal class ProfesionService
    {
        private string _connectionString;
        
        public ProfesionService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public string ObtenerDescripcionProfesion()
        {
            return UsuarioSingleton.Instance.UsuarioAutenticado.Profesion.TipoProfesion;
            }
        }
    }



