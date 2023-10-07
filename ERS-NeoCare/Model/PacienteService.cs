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
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM paciente";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(data);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                }
            }
            return data;
        }
        public Model.PacienteService Paciente(string dni)
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

                            return new Model.PacienteService
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

        public bool InsertarPaciente(Model.PacienteService paciente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Paciente (dni, nombre, apellido, domicilio, sexo, obra_social) " +
                                                                "VALUES (@dni, @nombre, @apellido, @domicilio, @sexo, @obra_social)", connection))
                    {
                        command.Parameters.AddWithValue("@dni", paciente.Dni);
                        command.Parameters.AddWithValue("@nombre", paciente.Nombre);
                        command.Parameters.AddWithValue("@apellido", paciente.Apellido);
                        command.Parameters.AddWithValue("@domicilio", paciente.Domicilio);
                        command.Parameters.AddWithValue("@sexo", paciente.Sexo);
                        command.Parameters.AddWithValue("@obra_social", paciente.ObraSocial);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Maneja la excepción de SQL Server aquí.
              
                Console.WriteLine("Error de SQL: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
            catch (Exception ex)
            {
                // Maneja otras excepciones generales aquí.
                //  excepciones de conexión, null reference, etc.
                Console.WriteLine("Error general: " + ex.Message);
                return false; 
            }
        }
    }

}