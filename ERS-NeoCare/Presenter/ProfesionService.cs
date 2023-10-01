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
        public string ObtenerDescripcionProfesion(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

       
                    using (SqlCommand command = new SqlCommand("SELECT * FROM profesion WHERE id = @idProfesion", connection))
                    {
                        command.Parameters.AddWithValue("@idProfesion", id);
                   

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                          return reader["tipo_profesion"].ToString();
                               
                            }
                        else
                        {
                            return null;
                        }
                        }
                        
                    }
                }
            }
        }
    }



