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
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox1.SelectedItem.ToString();

            // Utiliza un switch para tomar diferentes acciones según el valor seleccionado

            switch (seleccion)
            {
                case "Atendido":
                    presenter.CargarFiltro(true);
                    break;


                case "No Atendido":
                    presenter.CargarFiltro(false);
                    break;
                case "Todos":
                    presenter.traerOrdenes();
                    break;
                default:
                    presenter.traerOrdenes();
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox2.SelectedItem.ToString();

            // Utiliza un switch para tomar diferentes acciones según el valor seleccionado

            switch (seleccion)
            {
                case "Urgente":
                    presenter.FiltroUrgencia(true);
                    break;


                case "No Urgente":
                    presenter.FiltroUrgencia(false);
                    break;
                case "Todos":
                    presenter.traerOrdenes();
                    break;
                default:
                    presenter.traerOrdenes();
                    break;
            }
          


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBox2.Text;

            presenter.BuscarMedico(searchText);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
