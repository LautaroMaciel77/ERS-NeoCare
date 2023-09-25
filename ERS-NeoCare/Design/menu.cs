using ERS_NeoCare.Design.administrativo;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class menu : Form
    {
        private string userDni;
        private int profesionId;
        private SqlConnection connection;

        public menu(string dni)
        {

            this.userDni = dni;
            InitializeComponent();

            // Establece la cadena de conexión a la base de datos.
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

            // Crea la conexión a la base de datos.
            connection = new SqlConnection(connectionString);
            connection.Open();

            // Llama al método CargarProfesion para establecer el texto del Label.
            CargarProfesion();

            // Cierra la conexión cuando se cierre el formulario.
            this.FormClosing += Menu_FormClosing;
        }

        // Resto del código del formulario...

        private void CargarProfesion()
        {
            // Obtener el profesion_id de la tabla personal_salud basado en el dni.
            using (SqlCommand command = new SqlCommand("SELECT profesion_id FROM personal_salud WHERE dni = @Dni", connection))
            {
                command.Parameters.AddWithValue("@Dni", userDni);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int profesionId = Convert.ToInt32(result);
                    cargarUserControl(profesionId);
                    // la descripción de la profesión.
                    string descripcionProfesion = ObtenerDescripcionProfesion(profesionId);

                    // Asigna la descripción de la profesión al Label.
                    labelProfesion.Text = descripcionProfesion;
                }
                else
                {
                    MessageBox.Show("No se encontró una profesión para este usuario.");
                }
            }
        }

        // Método para obtener la descripción de la profesión basado en el profesion_id.
        private string ObtenerDescripcionProfesion(int profesionId)
        {
            using (SqlCommand command = new SqlCommand("SELECT tipo_profesion FROM profesion WHERE id = @ProfesionId", connection))
            {
                command.Parameters.AddWithValue("@ProfesionId", profesionId);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return "Profesión no encontrada"; // Puedes cambiar este mensaje si lo deseas.
                }
            }
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void cargarUserControl(int profesionId)
        {
            switch (profesionId)
            {
                case 1:
                    Administrativo ad = new Administrativo();
                    ad.OpcionesButtonClick += Administrativo_OpcionesButtonClick; // Suscribe al evento
                    ad.TurnoAdminButtonClick += AdmnistrativoTurnoAdminButtonClick;
                    addUserControl(ad, panelSubMenu);
                    break;
                case 2:
                    enfermero en = new enfermero();
                    
                    addUserControl(en, panelSubMenu);

                    break;
                case 3:
                    medico m = new medico();
                    m.TurnoAdminButtonClick += TurnoAdminButtonClick;
                    m.PacienteButtonClick += PacienteButtonClick;
                    addUserControl(m, panelSubMenu);
                    break;
                case 4:
                    bioquimico b = new bioquimico();
                    addUserControl(b, panelSubMenu);
                    break;

                default:

                    break;
            }
        }

        private void PacienteButtonClick(object sender, EventArgs e)
        {
            PacientesMedico pm = new PacientesMedico();
            addUserControl(pm, panelOpciones);
        }

        private void TurnoAdminButtonClick(object sender, EventArgs e)
        {
            TurnosMedico tm = new TurnosMedico();
            addUserControl(tm, panelOpciones);
        }



        private void addUserControl(UserControl userControl, Panel panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AdmnistrativoTurnoAdminButtonClick(object sender, EventArgs e)
        {
            turnoAdministrativo turno = new turnoAdministrativo(null);
            addUserControl(turno, panelOpciones);
        }

        private void Administrativo_OpcionesButtonClick(object sender, EventArgs e)
        {
            lista_paciente lista = new lista_paciente();
            lista.historiaPacienteClick += ListaPaciente_CargarOtroControlClick;
            lista.TurnoPacienteClick += turnoPacienteCargar;
            addUserControl(lista, panelOpciones);
        }

        private void ListaPaciente_CargarOtroControlClick(object sender, Tuple<string> args)
        {
            string dni_paciente = args.Item1;
            paciente paciente = new paciente(dni_paciente);
            addUserControl(paciente, panelOpciones);
        }

        private void turnoPacienteCargar(object sender, Tuple<string> args)
        {
            string dni_paciente = args.Item1;
            turnoAdministrativo turno = new turnoAdministrativo(dni_paciente);
            addUserControl(turno, panelOpciones);
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}