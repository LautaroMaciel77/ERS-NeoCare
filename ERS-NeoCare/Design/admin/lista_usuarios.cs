using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Medico;
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


        public lista_usuarios()
        {

            InitializeComponent();
            CargarDatosPaciente();
            panelAgregar.Visible = false;
         



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

       

    
        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
            

        }




        private void iconClose_Click_1(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }

        private void iconTurno_Click(object sender, EventArgs e)
        {
            TurnoPacienteClick?.Invoke(this, Tuple.Create(userDni));

        }

        private void iconVer_Click(object sender, EventArgs e)
        {
            historiaPacienteClick?.Invoke(this, Tuple.Create(userDni));

        }

        private void DGVAdministrativo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int columnIndexDNI = 0;                   
                    panelAgregar.Visible = true;
                    MenuAdminUsuarios ma = new MenuAdminUsuarios();
                    panelAgregar.Visible = true;
                    ma.Dock = DockStyle.Fill;
                    ma.closeclick += closeclick;
                    panelAgregar.Controls.Clear();
                    panelAgregar.Controls.Add(ma);
                    ma.BringToFront();

                }
            }
        }

        private void closeclick(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            agregar_usuario ap = new agregar_usuario();
           // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                panelOpciones.Controls.Clear();


                panelOpciones.Controls.Add(ap);




            }
        }
    }
}