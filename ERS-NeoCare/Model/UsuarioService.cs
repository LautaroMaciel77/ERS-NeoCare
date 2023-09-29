using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    using System.Data.SqlClient;

    public class UsuarioService
    {
        private string _connectionString;

        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UsuarioModel Authenticate(string nombreUsuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM personal_salud WHERE dni = @NombreUsuario AND pass = @Contraseña", connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UsuarioModel
                            {
                                Matricula = Convert.ToInt32(reader["matricula"]),
                                DNI = Convert.ToInt32(reader["dni"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                ProfesionID = Convert.ToInt32(reader["profesion_id"]),
                                Password = reader["pass"].ToString()
                            };
                        }
                    }
                }
            }

            return null; // Si no se encuentra el usuario
        }
    }
}
