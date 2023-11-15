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
            
            labelFechaOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Paciente.Nombre + " " + AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Paciente.Apellido;
            labelPacienteDniOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Medico.NombreApellido;
            labelMedicoMatriculaOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Medico.Matricula.ToString();
            textBoxOrdenIndicaciones.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Indicaciones;

            labelNumeroAnalisis.Text = AnalisisSingleton.Instance.AnalisisAutenticado.IdAnalisis.ToString();
            labelFechaAnalisis.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Fecha.ToString("dd/MM/yyyy");
            labelAnalisisBioquimico.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.NombreApellido;
            labelAnalisisBioquimicoMatricula.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.Matricula.ToString();
            labelAnalisisTipo.Text = AnalisisSingleton.Instance.AnalisisAutenticado.TipoAnalisis;
            textBoxObservaciones.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Observaciones;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    }

}

     
    

