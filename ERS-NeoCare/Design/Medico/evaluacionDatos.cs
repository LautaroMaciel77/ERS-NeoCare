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
