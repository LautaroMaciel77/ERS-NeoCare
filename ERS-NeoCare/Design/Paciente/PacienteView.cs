using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Paciente;
using ERS_NeoCare.Model;
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
    public partial class PacienteView : UserControl
    {
        private string userDni;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
          private menu MainForm { get; set; }
        public delegate void AgregarUserControlEventHandler(object sender, PacienteService paciente);
        public event AgregarUserControlEventHandler AgregarUserControlClicked;
        public PacienteView(PacienteService paciente)
        {
         
            // Establece la cadena de conexión a la base de datos.
            InitializeComponent();
            CargarPaciente(paciente);
         
        }
        private void CargarPaciente(PacienteService paciente)
        {


        
                         
                            labelDni.Text += paciente.Dni;
                            labelNombre.Text += paciente.Nombre;
                            labelApellido.Text += paciente.Apellido;
                            labelDomicilio.Text += paciente.Domicilio;
                            labelSexo.Text += paciente.Sexo;
                            labelObra.Text += paciente.ObraSocial;

            int dniAsInt = int.Parse(userDni);
            MessageBox.Show("DNI como entero: " + userDni, "Valor Convertido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Paciente WHERE dni = @dni"; // Cambia esto según tus necesidades

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Configura el parámetro para el ID del paciente que deseas cargar
                    command.Parameters.AddWithValue("@dni", dniAsInt); 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Nombre = reader["nombre"].ToString();
                            string apellido = reader["apellido"].ToString();
                            string domicilio = reader["domicilio"].ToString();
                            string fechaNacimiento = reader["fecha_nacimiento"].ToString();
                            string sexo = reader["sexo"].ToString();
                            string obraSocial = reader["obra_social"].ToString();
                            labelDni.Text += dniAsInt.ToString();
                            labelNombre.Text += Nombre;
                            labelApellido.Text += apellido;
                            labelDomicilio.Text += domicilio;
                            labelFecha.Text += fechaNacimiento;
                            labelSexo.Text += sexo;
                            labelObra.Text += obraSocial;


                        }
                    }
                }
            }
        }

        private void PBPaciente_Click(object sender, EventArgs e)
        {

                    
        }

   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HistoriaClinica historiaClinica = new HistoriaClinica();

            historiaClinica.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(historiaClinica);
            historiaClinica.BringToFront();

        }

       
    }
}

       

