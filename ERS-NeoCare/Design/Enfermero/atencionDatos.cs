using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class atencionDatos : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private AtencionPresenter _presenter;
        private OrdenPresenter _presenterorden;
        public event EventHandler recargar;
        public atencionDatos()
        {
            _presenter = new AtencionPresenter(new AtencionService());
            _presenterorden = new OrdenPresenter(new OrdenService());
            InitializeComponent();

            labelNumeroOrden.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.Id.ToString();
            labelFechaOrden.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.Paciente.Nombre + " " + 
                                            AtencionSingleton.Instance.AtencionAutenticada.Orden.Paciente.Apellido;
            labelPacienteDniOrden.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.Medico.NombreApellido;
            labelMedicoMatriculaOrden.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.Medico.Matricula.ToString();
            textBoxOrdenIndicaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Orden.Indicaciones;

            labelNumeroAtencion.Text = AtencionSingleton.Instance.AtencionAutenticada.IdAtencion.ToString();
            labelFechaAtencion.Text = AtencionSingleton.Instance.AtencionAutenticada.Fecha.ToString("dd/MM/yyyy");
            
            //cambiar por enfermero
            labelEnfermeroAtencion.Text = AtencionSingleton.Instance.AtencionAutenticada.Usuario.NombreApellido;
            labelEnfermeroMatriculaAtencion.Text = AtencionSingleton.Instance.AtencionAutenticada.Usuario.Matricula.ToString();
            textBoxAtencionIndicaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Indicaciones;
            textAtencionObservaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Observaciones;

        }

   
    }
}
