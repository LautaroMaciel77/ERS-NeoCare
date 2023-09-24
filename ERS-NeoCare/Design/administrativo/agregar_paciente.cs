using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class agregar_paciente : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        public agregar_paciente()
        {
            InitializeComponent();
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
            UserControlClosed?.Invoke(this, EventArgs.Empty);
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

              
        }

        private void textObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
