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
    public partial class lista_paciente_enfermero : UserControl
    {
        // Establece la cadena de conexión a la base de datos.
   
        public string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;
        public Model.PacienteService paciente;
        private menu MainForm { get; set; }
        // Declara un evento personalizado para notificar clics en los botones

        private ListaPacienteEnf _presenter;
        public lista_paciente_enfermero()
        {

            InitializeComponent();
            // panelAgregar.Visible = false;
            _presenter = new ListaPacienteEnf(this, new Presenter.PacienteService(Configuracion.ConnectionString));
            _presenter.CargarDatosPaciente();
            panelAgregar.Visible = false;

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
            PacienteView pacienteControl = new PacienteView(paciente);
            pacienteControl.Dock = DockStyle.Fill;

            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;
                panelOpciones.Controls.Clear();
                panelOpciones.Controls.Add(pacienteControl);
            }
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
                    int columnIndexDNI = 0;
                    this.userDni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                    _presenter.cargarMenu();
               
                }
            }
        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            //panelMenuPaciente.Visible = false;
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
          
        }
    }
}