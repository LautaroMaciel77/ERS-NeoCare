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
        private PacientePresenter _presenterPaciente;
        private UsuarioPresenter _presenterMedico;
        private menu MainForm { get; set; }


        private ListaPacienteEnf _presenter;
        public lista_paciente_enfermero()
        {

            InitializeComponent();
            // panelAgregar.Visible = false;
            _presenter = new ListaPacienteEnf(this, new OrdenService());
            _presenterPaciente = new PacientePresenter(new PacienteService(Configuracion.ConnectionString));
            _presenterMedico = new UsuarioPresenter(new UsuarioService(Configuracion.ConnectionString));

            _presenter.CargarDatosPaciente();
            panelAgregar.Visible = false;

        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }

        public void MostrarMenu( )
        {

            MenuEnfermeroAtencion mp = new MenuEnfermeroAtencion();
         
            mp.closeclick += closeclick;
            mp.verclick += verclick;
            mp.atenderClick+= atenderclick;
         

            cargarUserControl(mp);
        }

        private void atenderclick(object sender, EventArgs e)
        {
            atencion atencion = new atencion();
            atencion.Dock = DockStyle.Fill;
            atencion.recargar += recargar;

            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                panelOpciones.Controls.Clear();


                panelOpciones.Controls.Add(atencion);

            }
        }

        private void recargar(object sender, EventArgs e)
        {
            DGVAdministrativo.Invalidate();
            DGVAdministrativo.Refresh();
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
                        string medico = DGVAdministrativo.Rows[e.RowIndex].Cells["dni_medico"].Value.ToString();
                        string idOrden = DGVAdministrativo.Rows[e.RowIndex].Cells["id"].Value.ToString();
                        int.TryParse(idOrden, out int id);
                        _presenterPaciente.cargarPaciente(dniPaciente);
                        _presenterMedico.Buscar(medico);
                        _presenter.Buscar(id);
                        MostrarMenu();


                    }
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            _presenter.buscarTexto(searchText);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox2.SelectedItem.ToString();

            // Utiliza un switch para tomar diferentes acciones según el valor seleccionado

            switch (seleccion)
            {
                case "Urgente":
                    _presenter.FiltroUrgencia(true);
                    break;


                case "No Urgente":
                    _presenter.FiltroUrgencia(false);
                    break;
                case "Todos":
                    _presenter.CargarDatosPaciente();
                    break;
                default:
                    _presenter.CargarDatosPaciente();
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


