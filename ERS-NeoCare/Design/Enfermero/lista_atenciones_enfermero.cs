using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
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
        public Model.PacienteService paciente;

        private listaPacienteBio _presenter;
        

        public lista_atenciones_enfermero()

        { 

            InitializeComponent();
            CargarDatosPaciente();
            //panelMenuPaciente.Visible = false;
        }

        private void CargarDatosPaciente()
        {
            // Crea una conexión a la base de datos.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                 
                    string query = "SELECT * FROM paciente";

                
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Llena el DataSet con los datos de la consulta.
                    adapter.Fill(dataSet, "Paciente");

                    // Asigna el DataSet como origen de datos para el DataGridView.
                    DGVAdministrativo.DataSource = dataSet.Tables["Paciente"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de la tabla paciente: " + ex.Message);
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //panelMenuPaciente.Visible = false;
            //panelAgregarPaciente.Visible = true;


        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    atencion atencion = new atencion();
                    atencion.Dock = DockStyle.Fill;

                    // Accede al formulario 'menu' desde el control actual
                    menu menuForm = this.ParentForm as menu;

                    if (menuForm != null)
                    {
                        Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                        panelOpciones.Controls.Clear();


                        panelOpciones.Controls.Add(atencion);




                    }

                }
            }
        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            //panelMenuPaciente.Visible = false;
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            historiaPacienteClick?.Invoke(this, Tuple.Create(userDni));
        }
    }
}