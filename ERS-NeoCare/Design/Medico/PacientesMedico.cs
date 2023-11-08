using ERS_NeoCare.Design.Medico;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;


namespace ERS_NeoCare.Design
{

    public partial class PacientesMedico : UserControl
    {
        public PacienteModel paciente;
        private menu MainForm { get; set; }
        public string userDni;
        public event EventHandler<Tuple<string>> TurnoMedicoClick;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

        private TurnoPresenter _presenter;
        private PacientePresenter _pacientePresenter;
        public PacientesMedico()
        {
            InitializeComponent();
            _presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));
            _pacientePresenter = new PacientePresenter(new Presenter.PacienteService(Configuracion.ConnectionString));
            _presenter.CargarPacientePorTurno();
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




        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int columnIndexDNI = 0;
                    this.userDni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                    _pacientePresenter.cargarPaciente(userDni);
                    MenuMedicoPacientes menuPaciente = new MenuMedicoPacientes();
                    menuPaciente.closeclick += closeclick;
                    menuPaciente.cambiarEstado += cambiarEstado;
                    cargarUserControl(menuPaciente);

                }
            }
        }

        private void cambiarEstado(object sender, EventArgs e)
        {
            _presenter.cambiarEstado(PacienteSingleton.Instance.pacienteAutenticado.Id);
        }

        private void verclick(object sender, EventArgs e)
        {
            PacienteView pacienteControl = new PacienteView();
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

        private void closeclick(object sender, EventArgs e)
        {
            panelPaciente.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;

            _presenter.BuscarPacienteMedico(searchText);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox1.SelectedItem.ToString();

            // Utiliza un switch para tomar diferentes acciones según el valor seleccionado
            switch (seleccion)
            {
                case "Atendido":
                    _presenter.CargarFiltro("s");
                    break;
                case "No Atendido":
                    _presenter.CargarFiltro("n");
                    break;

            }
        }

        internal void mensaje(string v)
        {
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

