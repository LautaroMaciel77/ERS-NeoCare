using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Medico;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_baja_usuarios : UserControl
    {


        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;
        public event EventHandler<Tuple<string>> TurnoPacienteClick;

        private UsuarioPresenter _presenter;
        private menu MainForm { get; set; }


        public lista_baja_usuarios()
        {

            InitializeComponent();
            _presenter = new UsuarioPresenter(this, new UsuarioService(Configuracion.ConnectionString));

            CargarDatosPaciente();
            panelAgregar.Visible = false;
     
        }

        private void CargarDatosPaciente()
        {
            // Crea una conexión a la base de datos.
            _presenter.ObtenerUsuario("s");
        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
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
                     
                    panelAgregar.Visible = true;
                    MenuAdminUsuarios ma = new MenuAdminUsuarios();
                    panelAgregar.Visible = true;
                    ma.Dock = DockStyle.Fill;
                    ma.closeclick += closeclick;
                    ma.bajaclick += bajaclick;
                    panelAgregar.Controls.Clear();
                    panelAgregar.Controls.Add(ma);
                    ma.BringToFront();

                }
            }
        }

        private void bajaclick(object sender, EventArgs e)
        {
            
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