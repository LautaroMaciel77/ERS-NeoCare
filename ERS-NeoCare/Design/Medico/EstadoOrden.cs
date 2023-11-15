using ERS_NeoCare.Helper;
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
            {
                string seleccionEstado = comboBox1.SelectedItem?.ToString();
                string seleccionUrgencia = comboBox2.SelectedItem?.ToString();
                string seleccionTipo = comboBoxTipo.SelectedItem?.ToString();

                // Convertir las cadenas a valores booleanos
                bool? estado = !string.IsNullOrEmpty(seleccionEstado) ? (seleccionEstado.ToLower() == "atendido") : (bool?)null;
                bool? urgencia = !string.IsNullOrEmpty(seleccionUrgencia) ? (seleccionUrgencia.ToLower() == "urgente") : (bool?)null;

                bool filtrarPorEstado = seleccionEstado?.ToLower() == "todos";
                bool filtrarPorUrgencia = seleccionUrgencia?.ToLower() == "todos";
                bool filtrarPorTipo = seleccionTipo?.ToLower() == "todos";


                if (filtrarPorEstado && filtrarPorUrgencia && filtrarPorTipo)
                {
                    // Realizar la acción correspondiente cuando todos son "todos"
                    presenter.traerOrdenes();
                }
                else
                {
                    // Realizar la búsqueda según las selecciones específicas
                    presenter.CargarFiltro(
                        filtrarPorEstado ? null : estado,
                        filtrarPorUrgencia ? null : urgencia,
                        filtrarPorTipo ? null : seleccionTipo
                    );
                }
            }
        }
    }
} 
        
