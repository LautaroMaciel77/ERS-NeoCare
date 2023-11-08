using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services.Description;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_paciente_enfermero : UserControl
    {
        // Establece la cadena de conexión a la base de datos.

        public string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;
        public PacienteModel paciente;
        private PacienteService _service;
        private UsuarioPresenter _serviceMedico;
        private menu MainForm { get; set; }


        private ListaPacienteEnf _presenter;
        public lista_paciente_enfermero()
        {

            InitializeComponent();
            // panelAgregar.Visible = false;
            _presenter = new ListaPacienteEnf(this, new OrdenService());
            _presenter.CargarDatosPaciente();
            panelAgregar.Visible = false;

        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }

        public void MostrarMenu(PacienteModel paciente)
        {

            MenuEnfermeroAtencion mp = new MenuEnfermeroAtencion();
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
            PacienteView pacienteControl = new PacienteView();
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
                    if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        string dniPaciente = DGVAdministrativo.Rows[e.RowIndex].Cells["dni_paciente"].Value.ToString();
                        string medico = DGVAdministrativo.Rows[e.RowIndex].Cells["dni_medico"].ToString();

                        _service.BuscarPaciente(dniPaciente);
                        _serviceMedico.Buscar(medico);
                        atencion atencion = new atencion();
                        atencion.Dock = DockStyle.Fill;


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
        }
    }
}


