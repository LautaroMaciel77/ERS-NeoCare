using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class agregar_paciente : UserControl
    {
        public event EventHandler closeagregarclick;
        private PacientePresenter _presenter;
        public event EventHandler actualizarTabla;
        public agregar_paciente()
        {
            InitializeComponent();
            _presenter = new PacientePresenter( new Presenter.PacienteService(Configuracion.ConnectionString));
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
            if (!Regex.IsMatch(textObra.Text, "^[a-zA-Z]+$") || textDni.Text.Length > 8)
            {
                MessageBox.Show("El campo obra debe contener solo letras.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que al menos uno de los radio buttons esté seleccionado
            if (!radioMujer.Checked && !radioHombre.Checked)
            {
                MessageBox.Show("Seleccione una opción para el género.", "Género requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("Seleccione una fecha de nacimiento.", "Fecha de nacimiento requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PacienteModel paciente = new PacienteModel
            {
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                Domicilio = textDomicilio.Text,
                Dni = dni,
                ObraSocial = textObra.Text,
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
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
            if (!Regex.IsMatch(textObra.Text, "^[a-zA-Z]+$") || textDni.Text.Length > 8)
            {
                MessageBox.Show("El campo obra debe contener solo letras.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que al menos uno de los radio buttons esté seleccionado
            if (!radioMujer.Checked && !radioHombre.Checked)
            {
                MessageBox.Show("Seleccione una opción para el género.", "Género requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("Seleccione una fecha de nacimiento.", "Fecha de nacimiento requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PacienteModel paciente = new PacienteModel
            {
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                Domicilio = textDomicilio.Text,
                Dni = dni,
                ObraSocial = textObra.Text,
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

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelDni_Click(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void labelObra_Click(object sender, EventArgs e)
        {

        }

        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDomicilio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
