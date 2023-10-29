using ERS_NeoCare.Design.Medico;
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

    public partial class PacientesMedico : UserControl
    {
        public PacienteModel  paciente;
        private menu MainForm { get; set; }
        public string userDni;
        public event EventHandler<Tuple<string>> TurnoMedicoClick;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

        private ListaMedico _presenter;
        public PacientesMedico()
        {
            InitializeComponent();
            _presenter = new ListaMedico(this, new Presenter.PacienteService(Configuracion.ConnectionString));
            _presenter.CargarDatosPaciente();
            panelPaciente.Visible = false;

        }
        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }
        private void cargarUserControl(UserControl user)
        {
            panelPaciente.Visible = true;
            user.Dock = DockStyle.Fill;
            panelPaciente.Controls.Clear();
            panelPaciente.Controls.Add(user);
            user.BringToFront();

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
                    int columnIndexDNI = 0;
                    this.userDni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                    _presenter.cargarMenu();

                }
            }
        }
        public void MostrarMenu(PacienteModel paciente)
        {
            panelPaciente.Visible = true;
            MenuMedicoPacientes mp = new MenuMedicoPacientes(paciente);
            mp.closeclick += closeclick;
            this.paciente = paciente;
            cargarUserControl(mp);
        }

        private void verclick(object sender, EventArgs e)
        {
          
        }

        private void closeclick(object sender, EventArgs e)
        {
            panelPaciente.Visible = false;
        }
    }
}

