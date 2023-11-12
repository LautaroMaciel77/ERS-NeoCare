﻿using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class atencion : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private AtencionPresenter _presenter;
        public atencion()
        {
            _presenter = new AtencionPresenter(this, new AtencionService());
            InitializeComponent();

            labelFechaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Paciente.Apellido;
            labelPacienteDniOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Medico.Apellido;
            labelMedicoMatriculaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Matricula.ToString();

            textBoxOrdenIndicaciones.Text = OrdenSingleton.Instance.OrdenAutenticada.Indicaciones;



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
            int a = PacienteSingleton.Instance.pacienteAutenticado.Id;

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
                IdMedico = UsuarioBusqueda.Instance.UsuarioAutenticado.id,
                IdPaciente = PacienteSingleton.Instance.pacienteAutenticado.Id,
                IdOrden=OrdenSingleton.Instance.OrdenAutenticada.Id

            };
            _presenter.insertar(atencion);






        }




        internal void mensaje(string v)
        {
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
