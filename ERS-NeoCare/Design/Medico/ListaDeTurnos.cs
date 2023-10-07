using ERS_NeoCare.Design.Medico;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ERS_NeoCare.Design
{
    public partial class ListaDeTurnos : UserControl
    {
        private menu MainForm { get; set; }
        private string userDni;
        public event EventHandler<Tuple<string>> TurnoMedicoClick;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private TurnoMedico _presenter;
        public ListaDeTurnos()
        {
            InitializeComponent();
            cargarDatosPaciente();
            _presenter = new TurnoMedico(new PacienteService(Configuracion.ConnectionString));
           
        }

        private void cargarDatosPaciente()

        {

            // Crea  conexión  base de datos.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define una consulta SQL para seleccionar todos los registros de la tabla paciente.
                    string query = "SELECT * FROM paciente";

                    // Crea un adaptador de datos y un DataSet para almacenar los resultados.
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

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                  //  int columnIndexDNI = 0; // Reemplaza 'n' con el índice real de la columna DNI
                    //userDni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                   

                    //MenuMedicoPacientes tm = new MenuMedicoPacientes(_presenter.buscarPaciente(userDni));


                    // if (panelPaciente.Controls.Count > 0)
                    //  {
                    // Obtén el UserControl actual dentro del panelOpciones
                    //  agregar_paciente ap = (agregar_paciente)panelPaciente.Controls[0];
                    //
                    //
                    //   panelPaciente.Controls.Remove(ap);
                    //
                    //    ap.Dispose();
                    // }



                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

