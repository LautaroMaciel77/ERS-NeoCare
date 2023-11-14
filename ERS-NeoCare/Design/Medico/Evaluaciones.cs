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
    public partial class Evaluaciones : UserControl
    {
        private OrdenPresenter presenter;
        public Evaluaciones()
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
