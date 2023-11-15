using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class evaluacion : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private EvaluacionPresenter _presenter;
        private TurnoPresenter _presenterTurno;
        private historialPresenter _presenterHistorial;
        public evaluacion()
        {
            InitializeComponent();
            _presenter = new EvaluacionPresenter(this, new EvaluacionService());
            _presenterHistorial = new historialPresenter(new HistorialService());
            _presenterTurno = new TurnoPresenter(new TurnoService(Configuracion.ConnectionString));
            labelFechaEvaluacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelPacienteEvaluacion.Text = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;

        }



        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

       

        private void buttonClose_Click(object sender, EventArgs e)
        {
            UserControlClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Verificar si textNombre, textObservaciones y textBoxIndicaciones no están vacíos
            if (string.IsNullOrWhiteSpace(textObservaciones.Text))
            {
                MessageBox.Show("Por favor, complete Observaciones.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("Al insertar Evaluacion el Paciente pasara a Atendido. ¿Estás seguro?", "Confirmar Cambio de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                      
                return;




            }
            EvaluacionModel evaluacionModel = new EvaluacionModel()
            {
                FechaCreacion=DateTime.Now,
                Sintomas=textBoxSintomas.Text,
                Observaciones=textObservaciones.Text,
                Indicaciones=textBoxIndicacionesPaciente.Text,
                IdMedico=UsuarioSingleton.Instance.UsuarioAutenticado.id,
                IdPaciente=PacienteSingleton.Instance.pacienteAutenticado.Id
            };
            _presenter.insertar(evaluacionModel);
            limpiarCampos();
            HistorialModel historialModel = new HistorialModel()
            {
                Id = EvaluacionSingleton.Instance.evaluacionAutenticada.IdEvaluacion,
                Tipo = "Evaluacion",
                fecha = DateTime.Now,
                IdAtencion = null,
                IdPaciente = PacienteSingleton.Instance.pacienteAutenticado.Id,
                IdMedico = UsuarioSingleton.Instance.UsuarioAutenticado.id,
                IdEvaluacion = EvaluacionSingleton.Instance.evaluacionAutenticada.IdEvaluacion,
                IdAnalisis = null,


            };
            _presenterHistorial.Insertar(historialModel);
            _presenterTurno.cambiarEstado(TurnoSingleton.Instance.TurnoAutenticado.Id);
            volerPaciente();




        }

        private void volerPaciente()
        {
            PacientesMedico pacienteControl = new PacientesMedico();
            pacienteControl.Dock = DockStyle.Fill;

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                panelOpciones.Controls.Clear();


                panelOpciones.Controls.Add(pacienteControl);




            }
        }

        private void limpiarCampos()
        {
            textObservaciones.Text = null;
            textBoxSintomas.Text = null;
            textBoxIndicacionesPaciente.Text = null;

        }
        private void textObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            UserControlClosed?.Invoke(this, EventArgs.Empty);
        }

        internal void mostrarMensaje(string v)
        {
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
