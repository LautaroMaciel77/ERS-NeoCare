using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.Medico
{
    public partial class EstadoOrden : UserControl
    {
        private OrdenPresenter presenter;
        public EstadoOrden()
        {
            InitializeComponent();
            presenter = new OrdenPresenter(this, new OrdenService());
            presenter.traerOrdenes();
        }

        internal void cargarOrdenes(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
            DGVAdministrativo.Columns["Id"].Visible = false;

        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aca la funcion que imprima la orden
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int valorIdObject = (int)DGVAdministrativo.Rows[e.RowIndex].Cells["Id"].Value;
                 
                    DialogResult result = MessageBox.Show("¿Está seguro de querer ver los datos de esta orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Si el usuario confirma, buscar la orden y cargar los datos
                        presenter.buscarOrden(valorIdObject);
                        cargarOrdenDatos();
                    }
                }
            }

        }

        private void cargarOrdenDatos()
        {
            OrdenMedicoDatos pacienteControl = new OrdenMedicoDatos();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBox2.Text;

            presenter.BuscarMedico(searchText);
        }

 

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            string seleccionEstado = comboBox1.SelectedItem?.ToString();
            string seleccionUrgencia = comboBox2.SelectedItem?.ToString();
            string seleccionTipo = comboBoxTipo.SelectedItem?.ToString();

            // Verificar si al menos un ComboBox está seleccionado
            if (!string.IsNullOrEmpty(seleccionEstado) || !string.IsNullOrEmpty(seleccionUrgencia) || !string.IsNullOrEmpty(seleccionTipo))
            {
                // Convertir las cadenas a valores booleanos
                bool? estado = !string.IsNullOrEmpty(seleccionEstado) ? (seleccionEstado.ToLower() == "atendido") : (bool?)null;
                bool? urgencia = !string.IsNullOrEmpty(seleccionUrgencia) ? (seleccionUrgencia.ToLower() == "urgente") : (bool?)null;

                // Llamar a la función de búsqueda con los criterios seleccionados
                presenter.CargarFiltro(estado, urgencia, seleccionTipo);
            }
            else
            {
                // Manejar el caso donde ningún ComboBox está seleccionado
            }
        }


    }

}
