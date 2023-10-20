using System;

namespace ERS_NeoCare.Model
{
    using ERS_NeoCare.dbconexion;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;

    public class UsuarioService
    {
        private string _connectionString;

        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UsuarioModel Authenticate(string nombreUsuario, string contraseña)
        {
            int.TryParse(nombreUsuario, out int dni);
            using (var context = DbContextManager.GetContext())
            {
                // Buscar un usuario en la base de datos que coincida con el nombre de usuario y contraseña
                var usuario = context.Usuarios.FirstOrDefault(u => u.DNI == dni && u.Password == contraseña);
                context.Entry(usuario).Reference(u => u.Profesion).Load();
                // Si se encuentra un usuario, lo retornamos; de lo contrario, retornamos null
                return usuario;
            }
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
                                id = Convert.ToInt32(reader["id"]),
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
        public bool EditarUsuario(UsuarioModel usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE personal_salud " +
                                                       "SET " +"dni = @dni, " + 
                                                       "matricula = @matricula, " +
                                                           "nombre = @nombre, " +
                                                           "apellido = @apellido, " +
                                                           "profesion_id = @profesion_id, " +
                                                           "pass = @pass " +
                                                       "WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", usuario.id);
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
