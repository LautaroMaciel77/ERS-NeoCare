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
            panelAgregar.Visible = false;

            presenter = new AnalisisPresenter(this, new AnalisisService());

            presenter.TraerAnalisis();

        }
        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }



        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

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
    }
}