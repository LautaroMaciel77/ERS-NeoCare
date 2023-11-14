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
            _presenter = new AtencionPresenter(this, new AtencionService());
            _presenterorden = new OrdenPresenter(new OrdenService());
            InitializeComponent();

            labelFechaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Paciente.Apellido;
            labelPacienteDniOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Medico.Apellido;
            labelMedicoMatriculaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Matricula.ToString();

            textBoxOrdenIndicaciones.Text = OrdenSingleton.Instance.OrdenAutenticada.Indicaciones;



        }

   
    }
}
