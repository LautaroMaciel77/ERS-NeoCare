using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class evaluacionDatos : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private EvaluacionPresenter _presenter;
        public evaluacionDatos()
        {
            InitializeComponent();
            _presenter = new EvaluacionPresenter(this, new EvaluacionService());

            labelNumeroEvaluacion.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.IdEvaluacion.ToString();
            labelFechaEvaluacion.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteEvaluacion.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Paciente.Nombre + " " +
                                            EvaluacionSingleton.Instance.evaluacionAutenticada.Paciente.Apellido;
            labelPacienteDniEvaluacion.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Paciente.Dni.ToString();
            labelMedicoEvaluacion.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Medico.NombreApellido;
            labelMedicoMatriculaEvaluacion.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Medico.Matricula.ToString();

            textBoxSintomas.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Sintomas;
            textBoxIndicacionesPaciente.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Indicaciones;
            textObservaciones.Text = EvaluacionSingleton.Instance.evaluacionAutenticada.Observaciones;
        }

        
    }
}
