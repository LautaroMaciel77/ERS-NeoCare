using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class agregar_paciente : UserControl
    {
        public event EventHandler closeagregarclick;
        private AgregarPacientePresenter _presenter;
        public event EventHandler actualizarTabla;
        public agregar_paciente()
        {
            InitializeComponent();
            _presenter = new AgregarPacientePresenter(new Presenter.PacienteService(Configuracion.ConnectionString));
        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void radioMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMujer.Checked)
            {

                radioHombre.Checked = false;
            }
        }

        private void radioHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHombre.Checked)
            {

                radioMujer.Checked = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            closeagregarclick?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Verificar si textNombre, textApellido y textDomicilio no están vacíos
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textApellido.Text) || string.IsNullOrWhiteSpace(textDomicilio.Text)
                || string.IsNullOrWhiteSpace(textDni.Text) || string.IsNullOrWhiteSpace(textObra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si textDni contiene solo números y tiene un máximo de 8 caracteres
            if (!int.TryParse(textDni.Text, out int dni) || textDni.Text.Length > 8)
            {
                MessageBox.Show("El campo DNI debe contener solo números y tener un máximo de 8 caracteres.", "Formato de DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textObra.Text, out int obra) || textDni.Text.Length > 8)
            {
                MessageBox.Show("El campo obra  debe contener solo números .", "Formato  incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que al menos uno de los radio buttons esté seleccionado
            if (!radioMujer.Checked && !radioHombre.Checked)
            {
                MessageBox.Show("Seleccione una opción para el género.", "Género requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.PacienteService paciente = new Model.PacienteService()
            {
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                Domicilio = textDomicilio.Text,
                Dni = dni,
                ObraSocial = obra.ToString(),
                Sexo = radioMujer.Checked ? "Mujer" : "Hombre"
            };
            bool insercionExitosa = _presenter.IngresarPaciente(paciente);

            if (insercionExitosa)
            {
                MessageBox.Show("Paciente insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); 
            }
            else
            {
                MessageBox.Show("Hubo un problema al insertar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizarTabla?.Invoke(this, EventArgs.Empty);


        }
        private void LimpiarCampos()
        {
            // Código para limpiar los campos del formulario
            textDni.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textDomicilio.Clear();
            radioMujer.Checked = false;
            radioHombre.Checked = false;
            textObra.Clear();
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
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
            GC.Collect();
            closeagregarclick?.Invoke(this, EventArgs.Empty);
        }


        private void labelSexo_Click(object sender, EventArgs e)
        {

        }

        private void textObra_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAgregarPaciente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
