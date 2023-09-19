using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class paciente : UserControl
    {
        private string userDni;
        public paciente(string dni)
        {
            this.userDni = dni;
            // Establece la cadena de conexión a la base de datos.
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            CargarPaciente();
            InitializeComponent();
        }
        private void CargarPaciente()
        {
            // Establece la cadena de conexión a la base de datos.
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define la consulta SQL para obtener los datos del paciente con el dni correspondiente.
                    string query = "SELECT dni, nombre, apellido, domicilio, fecha_nacimiento, sexo, obra_social, FROM paciente WHERE dni = @Dni";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Establece el parámetro @Dni con el valor de userDni.
                        command.Parameters.AddWithValue("@Dni", userDni);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtiene los valores de las columnas de la consulta.
                                string dni = reader["dni"].ToString();
                                string nombre = reader["nombre"].ToString();
                                string apellido = reader["apellido"].ToString();
                                string domicilio = reader["domicilio"].ToString();
                                DateTime fechaNacimiento = (DateTime)reader["fecha_nacimiento"];
                                string sexo = reader["sexo"].ToString();
                                string obraSocial = reader["obra_social"].ToString();
                             

                                // Asigna los valores a los Label correspondientes.
                                LDni.Text += dni;
                                LNombre.Text += nombre;
                                LApellido.Text += apellido;
                                LDomicilio.Text += domicilio;
                                LFechaNacimiento.Text += fechaNacimiento.ToString("yyyy-MM-dd");
                                LSexo.Text += sexo;
                                LObraSocial.Text += obraSocial;
                               
                            }
                            else
                            {
                                MessageBox.Show("Paciente no encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del paciente: " + ex.Message);
                }
            }
        }

        private void PBPaciente_Click(object sender, EventArgs e)
        {

        }
    }

    }

