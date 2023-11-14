using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class analisisDatos : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private HistoriaClinicaPresenter _presenter;
        private ArchivoEstudioPresenter _presenterArchivo;
        private AnalisisPresenter _presenterAnalisis;
        private OrdenPresenter _presenterorden;
        private ArchivoEstudio archivo;
        public event EventHandler recargar;
        public analisisDatos()
        {
            _presenter = new HistoriaClinicaPresenter( new HistoriaClinicaService(Configuracion.ConnectionString));
            _presenterArchivo = new ArchivoEstudioPresenter(new ArchivoEstudioService(Configuracion.ConnectionString));
            _presenterAnalisis = new AnalisisPresenter(this, new AnalisisService());
            _presenterorden = new OrdenPresenter(new OrdenService());
            InitializeComponent();

            labelFechaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Paciente.Apellido;
            labelPacienteDniOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Medico.Apellido;
            labelMedicoMatriculaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Matricula.ToString();

            textBoxOrdenIndicaciones.Text = OrdenSingleton.Instance.OrdenAutenticada.Indicaciones;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    }

}

     
    

