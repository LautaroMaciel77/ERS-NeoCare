using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_analisis_bioquimico : UserControl
    {





        private AnalisisPresenter presenter;


        public lista_analisis_bioquimico()
        {

            InitializeComponent();


            presenter = new AnalisisPresenter(this, new AnalisisService());

            presenter.TraerAnalisis();

        }
        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }




        private void cargarOrdenDatos()
        {
            analisisDatos pacienteControl = new analisisDatos();
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
            {
                string searchText = textBox2.Text;
                presenter.buscarTexto(searchText);
            }


        }

        private void DGVAdministrativo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {

                    int id = (int)DGVAdministrativo.Rows[e.RowIndex].Cells["id"].Value;

                    DialogResult result = MessageBox.Show("¿Está seguro de querer ver los datos de este Analisis?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        presenter.BuscaryRemplazar(id);
                        cargarOrdenDatos();

                    }


                }

            }
        }
    }
}