using ERS_NeoCare.Design.administrativo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_usuarios : UserControl
    {


        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;
        public event EventHandler<Tuple<string>> TurnoPacienteClick;

        private menu MainForm { get; set; }
        // Declara un evento personalizado para notificar clics en los botones

        public lista_usuarios()
        {

            InitializeComponent();
            CargarDatosPaciente();
            panelMenuPaciente.Visible = false;
            panelOpciones.Visible = false;



        }

        private void CargarDatosPaciente()
        {
            // Crea una conexión a la base de datos.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define una consulta SQL para seleccionar todos los registros de la tabla paciente.
                    string query = "SELECT * FROM personal_salud";

                    // Crea un adaptador de datos y un DataSet para almacenar los resultados.
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Llena el DataSet con los datos de la consulta.
                    adapter.Fill(dataSet, "personal_salud");

                    // Asigna el DataSet como origen de datos para el DataGridView.
                    DGVAdministrativo.DataSource = dataSet.Tables["personal_salud"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de la tabla personal salud: " + ex.Message);
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelMenuPaciente.Visible = false;
            agregar_usuario agregar_usuarios = new agregar_usuario();
            agregar_usuarios.Dock = DockStyle.Fill;
            panelOpciones.Controls.Clear();
            panelOpciones.Controls.Add(agregar_usuarios);
            agregar_usuarios.BringToFront();
            panelOpciones.Visible = true;

        }

        private void closePanel(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
        }
        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    panelOpciones.Visible = false;
                    panelMenuPaciente.BringToFront();
                    panelMenuPaciente.Visible = true;
                    int columnIndexDNI = 0; // Reemplaza 'n' con el índice real de la columna DNI
                    userDni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                    if (panelOpciones.Controls.Count > 0)
                    {
                        // Obtén el UserControl actual dentro del panelOpciones
                        agregar_usuario ap = (agregar_usuario)panelOpciones.Controls[0];

                        // Remueve el UserControl del panelOpciones
                        panelOpciones.Controls.Remove(ap);


                        ap.Dispose();
                    }



                }
            }

        }




        private void iconClose_Click_1(object sender, EventArgs e)
        {
            panelMenuPaciente.Visible = false;
        }

        private void iconTurno_Click(object sender, EventArgs e)
        {
            TurnoPacienteClick?.Invoke(this, Tuple.Create(userDni));

        }

        private void iconVer_Click(object sender, EventArgs e)
        {
            historiaPacienteClick?.Invoke(this, Tuple.Create(userDni));

        }
    }
}