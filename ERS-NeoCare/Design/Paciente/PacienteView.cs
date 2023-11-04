using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Paciente;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
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
        private HistoriaClinicaPresenter _presenter;

        private menu MainForm { get; set; }
        // public delegate void AgregarUserControlEventHandler(object sender, PacienteService paciente);
        // public event AgregarUserControlEventHandler AgregarUserControlClicked;
        public PacienteView()
        {

            _presenter = new HistoriaClinicaPresenter(new HistoriaClinicaService(Configuracion.ConnectionString));
            InitializeComponent();

            CargarPaciente();
            btnAgregar.Visible = false;
            verificarUsuario();
     

        }



        private void CargarPaciente()
        {

            _presenter.Buscar();
            labelDni.Text += PacienteSingleton.Instance.pacienteAutenticado.Dni;

            labelNombre.Text += PacienteSingleton.Instance.pacienteAutenticado.Nombre;
            labelApellido.Text += PacienteSingleton.Instance.pacienteAutenticado.Apellido;

            labelDomicilio.Text += PacienteSingleton.Instance.pacienteAutenticado.Domicilio;
            labelFecha.Text += PacienteSingleton.Instance.pacienteAutenticado.FechaNacimiento;
            labelSexo.Text += PacienteSingleton.Instance.pacienteAutenticado.Sexo;
            labelObra.Text += PacienteSingleton.Instance.pacienteAutenticado.ObraSocial;


        }
        private void verificarUsuario()
        {
        
            if (HistoriaClinicaSingleton.Instance.historiaAutenticado != null)
            {
                CargarHC();
            }
            else if (UsuarioSingleton.Instance.UsuarioAutenticado.ProfesionID == 3){


                btnAgregar.Visible = true;

            }
        }






        private void PBPaciente_Click(object sender, EventArgs e)
        {


        }
        private void CargarHC()
        {
            HistoriaClinica historiaClinica = new HistoriaClinica();

            historiaClinica.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(historiaClinica);
            historiaClinica.BringToFront();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarHC();

        }

       
    }
}

       

