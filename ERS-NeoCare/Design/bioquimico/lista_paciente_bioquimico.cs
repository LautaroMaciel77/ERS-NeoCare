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
    public partial class lista_paciente_bioquimico : UserControl
    {
        // Establece la cadena de conexión a la base de datos.


        public string userDni;
        public Model.PacienteService paciente;
        //handler para cargar paciente


        private menu MainForm { get; set; }
        // Declara un evento personalizado para notificar clics en los botones
        private listaPacienteBio _presenter;
        public lista_paciente_bioquimico()
        {

            InitializeComponent();
            panelAgregar.Visible = false;
            _presenter = new listaPacienteBio(this, new Presenter.PacienteService(Configuracion.ConnectionString));
            _presenter.CargarDatosPaciente();
          
        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }

        public void MostrarMenu(Model.PacienteService paciente)
        {
            panelAgregar.Visible = true;
            menuPaciente mp = new menuPaciente();
            this.paciente = paciente;
            mp.closeclick += closeclick;
            mp.verclick += verclick;
            cargarUserControl(mp);
        }

        private void closeclick(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }

        private void verclick(object sender, EventArgs e)
        {
            //
        }

        private void cargarUserControl(UserControl user)
        {
            panelAgregar.Visible = true;
            user.Dock = DockStyle.Fill;
            panelAgregar.Controls.Clear();
            panelAgregar.Controls.Add(user);
            user.BringToFront();

        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // Obtén el valor de la celda "dni" de la fila en la que se hizo clic
                    this.userDni = DGVAdministrativo.Rows[e.RowIndex].Cells["dni"].Value.ToString();

                    int columnIndexDNI = 0;
                    this.userDni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                    _presenter.cargarMenu();

                }

            }
        }

        

  


    }
}