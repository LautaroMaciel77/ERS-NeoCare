using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_atenciones_enfermero : UserControl
    {
        // Establece la cadena de conexión a la base de datos.

  
        private string userDni;
        //handler para cargar paciente


        private menu MainForm { get; set; }

        private AtencionPresenter _presenter;
        

        public lista_atenciones_enfermero()

        { 

            InitializeComponent();
            _presenter = new AtencionPresenter(this, new AtencionService());
            _presenter.ObtenerAtenciones();
            //panelMenuPaciente.Visible = false;
        }

        internal void CargarDatosPaciente(DataTable data)
        {
      DGVAdministrativo.DataSource = data;
        }


        

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
            }
        }





        
 

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            _presenter.buscarTexto(searchText);
        }
    }
}