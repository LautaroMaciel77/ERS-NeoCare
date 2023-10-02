using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data);
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
