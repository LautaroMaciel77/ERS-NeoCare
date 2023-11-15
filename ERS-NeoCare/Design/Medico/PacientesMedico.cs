using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Medico;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web.Services.Description;
using System.Windows.Forms;


namespace ERS_NeoCare.Design
{

    public partial class PacientesMedico : UserControl
    {
        public PacienteModel paciente;
      
        public string userDni;
        public event EventHandler<Tuple<string>> TurnoMedicoClick;
        private int IdPaciente;
        private int idTurno;
        private TurnoPresenter _presenter;
        private PacientePresenter _pacientePresenter;
        private EvaluacionPresenter evaluacionPresenter;
        public PacientesMedico()
        {
            InitializeComponent();
            _presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));
            _pacientePresenter = new PacientePresenter(new Presenter.PacienteService(Configuracion.ConnectionString));
            evaluacionPresenter = new EvaluacionPresenter(new EvaluacionService());
            _presenter.CargarPacienteMedico();
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
                    string dniPaciente = DGVAdministrativo.Rows[e.RowIndex].Cells["PacienteDni"].Value.ToString();
                    idTurno = (int)DGVAdministrativo.Rows[e.RowIndex].Cells["Id"].Value;
                    _pacientePresenter.cargarPaciente(dniPaciente);
                    _presenter.BuscarYAuntenticar(idTurno);

                    MenuMedicoPacientes menuPaciente = new MenuMedicoPacientes();
                    menuPaciente.closeclick += closeclick;
                    menuPaciente.cambiarEstado += cambiarEstado;
                    menuPaciente.registrarclick += registrarClick;
                    cargarUserControl(menuPaciente);

                }
            }
        }

        private void registrarClick(object sender, EventArgs e)
        {
   
            
            evaluacion pacienteControl = new evaluacion();
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

        private void cambiarEstado(object sender, EventArgs e)
        {
         
            DialogResult resultado = MessageBox.Show("Al cambiar a 'Atendido', ya no podrás realizar más acciones a este turno y pasará a la vista de evaluaciones. ¿Estás seguro?", "Confirmar Cambio de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cambiar el estado
                _presenter.cambiarEstado(idTurno);

                // Invalidar y refrescar el DataGridView
                DGVAdministrativo.DataSource = null;
                _presenter.CargarPacienteMedico();
                DGVAdministrativo.Refresh();
        
     
    

            }

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
                    _presenter.CargarFiltro(true);
                    break;


                case "No Atendido":
                    _presenter.CargarFiltro(false);
                    break;
                case "Todos":
                    _presenter.CargarPacienteMedico();
                    break;
                default:
                    _presenter.CargarPacienteMedico();
                    break;
            }
        }

        internal void mensaje(string v)
        {
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

