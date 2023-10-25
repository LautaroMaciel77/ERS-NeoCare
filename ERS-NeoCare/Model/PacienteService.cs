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


        public DataTable ObtenerDatosPaciente()
        {
            DataTable dataTable = new DataTable();

            try
            {
                var context = DbContextManager.GetContext();
                
                    var pacientes = context.Pacientes.ToList(); // Obtener todos los pacientes de la base de datos

                    // Definir las columnas en el DataTable
                    dataTable.Columns.Add("id", typeof(int));
                    dataTable.Columns.Add("dni", typeof(int));
                    dataTable.Columns.Add("nombre", typeof(string));
                    dataTable.Columns.Add("apellido", typeof(string));
                    dataTable.Columns.Add("domicilio", typeof(string));
                    dataTable.Columns.Add("fecha_nacimiento", typeof(DateTime));
                    dataTable.Columns.Add("sexo", typeof(string));
                    dataTable.Columns.Add("obra_social", typeof(string));
                    dataTable.Columns.Add("historia_clinica_id", typeof(int));
                    dataTable.Columns.Add("baja", typeof(string));
                    dataTable.Columns.Add("condicion", typeof(string));

                    // Agregar filas al DataTable
                    foreach (var paciente in pacientes)
                    {
                        dataTable.Rows.Add(paciente.Id, paciente.Dni, paciente.Nombre, paciente.Apellido, paciente.Domicilio, paciente.FechaNacimiento, paciente.Sexo, paciente.ObraSocial, paciente.HistoriaClinicaId, paciente.Baja, paciente.Condicion);
                    }
                
            }
            catch (Exception ex)
            {
                // Manejar excepciones
            }

            return dataTable;
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

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                System.Windows.Forms.MessageBox.Show("El número de DNI es: " + dni, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (SqlCommand command = new SqlCommand("SELECT * FROM Paciente WHERE dni = @dni", connection))
                {
                    command.Parameters.AddWithValue("@dni", dni);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return new PacienteModel
                            {
                                Dni = Convert.ToInt32(reader["dni"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Domicilio = reader["Domicilio"].ToString(),
                                Condicion = reader["Condicion"].ToString(),


                            };

                        }
                    }
                }
            }
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