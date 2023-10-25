using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Paciente;
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
          private menu MainForm { get; set; }
       // public delegate void AgregarUserControlEventHandler(object sender, PacienteService paciente);
       // public event AgregarUserControlEventHandler AgregarUserControlClicked;
        public PacienteView()
        {
         
            // Establece la cadena de conexión a la base de datos.
            InitializeComponent();
          //  CargarPaciente();
         
        }
        private void CargarPaciente(PacienteService paciente)
        {


        
                         
                        //    labelDni.Text += paciente.Dni;
                         //   labelNombre.Text += paciente.Nombre;
                           // labelApellido.Text += paciente.Apellido;
                            //labelDomicilio.Text += paciente.Domicilio;
                            //labelSexo.Text += paciente.Sexo;
                            //labelObra.Text += paciente.ObraSocial;


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

       

