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

        private string connectionString = Configuracion.ConnectionString;
        private string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;

        private menu MainForm { get; set; }

        private AtencionPresenter _presenter;
        

        public lista_atenciones_enfermero()

        { 

            InitializeComponent();
          _presenter =  new AtencionPresenter(this, new AtencionService());
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





        private void iconButton3_Click(object sender, EventArgs e)
        {
            historiaPacienteClick?.Invoke(this, Tuple.Create(userDni));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            _presenter.buscarTexto(searchText);
        }
    }
}