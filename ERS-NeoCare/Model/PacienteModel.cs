using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class PacienteModel
    {
        private string _connectionString;
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string ObraSocial { get; set; }
        public int? HistoriaClinicaId { get; set; }
        public string Condicion { get; set; }

        public PacienteModel(string connectionString)
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
        public void Paciente(string dni)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Paciente WHERE dni = @dni", connection))
                {
                    command.Parameters.AddWithValue("@dni", dni);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {



                            Dni = Convert.ToInt32(reader["dni"]);
                            Nombre = reader["nombre"].ToString();
                            Apellido = reader["apellido"].ToString();
                            Domicilio = reader["Domicilio"].ToString();
                            Apellido = reader["apellido"].ToString();
                            Condicion = reader["Condicion"].ToString();
                            HistoriaClinicaId = Convert.ToInt32(reader["profesion_id"]);
                            ObraSocial = reader["ObraSocial"].ToString();

                        }
                    }
                }
            }
        }
    }
}



