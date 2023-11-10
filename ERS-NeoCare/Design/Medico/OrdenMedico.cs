
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class OrdenMedico : UserControl
    {
        private DateTime select;
        private string dni;
        private string rangoHora;
        private bool urgencia;
        private OrdenPresenter presenter;
        public OrdenMedico()
        {
            InitializeComponent();

            presenter = new OrdenPresenter(this, new OrdenService());
        }



        private void iconAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxIndicaciones.Text))
            {
                MessageBox.Show("El campo indicaciones no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
          
           

        }

        private void textboxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }



   
        

        internal void mensaje(string v)
        {
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            urgencia = true;
            if (radioButtonSi.Checked)
            {
                radioButtonNo.Checked = false;
          
            }
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un tipo de orden
            if (comboBox1.SelectedItem == null)
            {
                mensaje("Debe seleccionar un tipo de orden.");
                return; // No se procede si no se ha seleccionado un tipo de orden
            }

            // Validar que se haya ingresado indicaciones
            if (string.IsNullOrEmpty(textBoxIndicaciones.Text))
            {
                mensaje("Debe ingresar indicaciones.");
                return; // No se procede si no se han ingresado indicaciones
            }
            OrdenModel orden = new OrdenModel
            {
                TipoOrden = comboBox1.SelectedItem.ToString(),
                Urgencia = urgencia,
                Indicaciones = textBoxIndicaciones.Text,
                IdPaciente = PacienteSingleton.Instance.pacienteAutenticado.Id,
                IdPersonalSalud = UsuarioSingleton.Instance.UsuarioAutenticado.id,
                FechaCreacion = DateTime.Now,
            };
            presenter.Insertar(orden);

        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            urgencia = false;
            if (radioButtonNo.Checked)
            {
        
                radioButtonSi.Checked = false; // Deselecciona checkBox2 si checkBox1 está seleccionado
            }
        }

        internal void cargarOrdenes(DataTable data)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
