﻿using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class atencion : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        public atencion()
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

       

        private void buttonClose_Click(object sender, EventArgs e)
        {
            UserControlClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Verificar si textNombre, textObservaciones y textBoxIndicaciones no están vacíos
            if (string.IsNullOrWhiteSpace(textObservaciones.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(textBoxIndicaciones.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtencionEnfermeriaModel atencion = new AtencionEnfermeriaModel()
            {
                Fecha = DateTime.Now,
                Observaciones = textObservaciones.Text,
                Indicaciones = textBoxIndicaciones.Text,
                Estado = false,
                IdUsuario = UsuarioSingleton.Instance.UsuarioAutenticado.id,
                IdMedico =  UsuarioBusqueda.Instance.UsuarioAutenticado.id,
                IdPaciente = PacienteSingleton.Instance.pacienteAutenticado.Id,


            };

            



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

        private void textDni_TextChanged(object sender, EventArgs e)
        {
                    }

        private void LabelDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIndicaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        internal void mensaje(string v)
        {
            throw new NotImplementedException();
        }
    }
}
