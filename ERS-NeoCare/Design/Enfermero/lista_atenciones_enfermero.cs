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
        private PacientePresenter _presenterPaciente;


        public lista_atenciones_enfermero()

        { 

            InitializeComponent();
            _presenter = new AtencionPresenter(this, new AtencionService());
            _presenterPaciente = new PacientePresenter(new PacienteService(Configuracion.ConnectionString));
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
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                 
                        string id = DGVAdministrativo.Rows[e.RowIndex].Cells["id"].Value.ToString();
                 
                    DialogResult result = MessageBox.Show("¿Está seguro de querer ver los datos de esta atencion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _presenter.buscar(id);
                        cargarOrdenDatos();
                    }


                }

            }
        }

        private void cargarOrdenDatos()
        {
            atencionDatos pacienteControl = new atencionDatos();
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

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            _presenter.buscarTexto(searchText);
        }
    }
}