using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERS_NeoCare.Design.Paciente;
using System.Net;
using System.Windows;
using ERS_NeoCare.Model;
using System.Windows.Forms;

namespace ERS_NeoCare.Presenter
{
    internal class PacienteService
    {
        private string _connectionString;

        public PacienteService(string connectionString)
        {
            _connectionString = connectionString;
        }


        public List<PacienteModel> ObtenerDatosPaciente()
        {
          
           
                var context = DbContextManager.GetContext();
                
                    var pacientes = context.Pacientes.ToList(); // Obtener todos los pacientes de la base de datos

                return pacientes;
                
        
        }
        public void BuscarPaciente(string dni)

        {
            int.TryParse(dni, out int dniInt);
            var context = DbContextManager.GetContext();

            var paciente = context.Pacientes.FirstOrDefault(u => u.Dni == dniInt);

            if (paciente != null)
            {
       
                PacienteSingleton.Instance.Autenticar(paciente);
            }

        }
        public PacienteModel Paciente(string dni)
        {

       
            return null; // Si no se encuentra el usuario

        }

        public bool InsertarPaciente(PacienteModel paciente)
        {
            try
            {
            var context = DbContextManager.GetContext();
               
                    // Agregar el paciente al contexto
                    context.Pacientes.Add(paciente);

                    // Guardar los cambios en la base de datos
                    int rowsAffected = context.SaveChanges();

                    return rowsAffected > 0;
                
            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }

    }

}