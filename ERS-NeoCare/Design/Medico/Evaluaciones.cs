using ERS_NeoCare.Design.administrativo;
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
        private EvaluacionPresenter presenter;
        public Evaluaciones()
        {
            InitializeComponent();
            presenter = new EvaluacionPresenter(this, new EvaluacionService());
            presenter.traerEvaluaciones();
        }

        internal void cargarEvaluaciones(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
     

        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aca la funcion que imprima la orden
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int valorIdObject = (int)DGVAdministrativo.Rows[e.RowIndex].Cells["Id"].Value;
                   
                    DialogResult result = MessageBox.Show("¿Está seguro de querer ver los datos de esta evaluacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        presenter.BuscarPorId(valorIdObject);
                        cargarOrdenDatos();
                    }
                }
            }
            }





        private void cargarOrdenDatos()
        {
            evaluacionDatos pacienteControl = new evaluacionDatos();
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



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBox2.Text;

          presenter.Buscar(searchText);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
