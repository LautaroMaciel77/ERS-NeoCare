using System;

namespace ERS_NeoCare.Model
{
    using System.Data;
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
        public UsuarioModel BuscarUsuario(string dni)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM personal_salud WHERE dni = @dni", connection))
                {
                    command.Parameters.AddWithValue("@dni", dni);
          
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
        public bool InsertarUsuario(UsuarioModel usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO personal_salud (dni, matricula, nombre, apellido, profesion_id, pass) " +
                                                                "VALUES (@dni, @matricula, @nombre, @apellido, @profesion_id, @pass)", connection))
                    {
                        command.Parameters.AddWithValue("@dni", usuario.DNI);
                        command.Parameters.AddWithValue("@matricula", usuario.Matricula);
                        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@profesion_id", usuario.ProfesionID);
                        command.Parameters.AddWithValue("@pass", usuario.Password);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // excepción de SQL Server aquí.
          
                Console.WriteLine("Error de SQL: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
            catch (Exception ex)
            {
                //  excepciones generales aquí.
                //  excepciones de conexión, null reference, etc.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }
        public bool CambiarEstadoBajaUsuario(int matricula)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE personal_salud " +
                                                              "SET baja = CASE WHEN baja = 'n' THEN 's' ELSE 'n' END " +
                                                              "WHERE matricula = @matricula", connection))
                    {
                        command.Parameters.AddWithValue("@matricula", matricula);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // excepción de SQL Server aquí.

                Console.WriteLine("Error de SQL: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
            catch (Exception ex)
            {
                // excepciones generales aquí.
                // excepciones de conexión, null reference, etc.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }
        public DataTable ObtenerDatosUsuario(string valorBaja)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM personal_salud WHERE baja = @ValorBaja";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar el parámetro @ValorBaja
                        command.Parameters.AddWithValue("@ValorBaja", valorBaja);

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
    }

}
