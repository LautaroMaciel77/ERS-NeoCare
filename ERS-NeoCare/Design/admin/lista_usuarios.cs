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
    public partial class lista_usuarios : UserControl
    {


        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;
        public event EventHandler<Tuple<string>> TurnoPacienteClick;
        public UsuarioModel usuario = new UsuarioModel();
        private UsuarioPresenter _presenter;
        private menu MainForm { get; set; }


        public lista_usuarios()
        {

            InitializeComponent();
            _presenter = new UsuarioPresenter(this, new UsuarioService(Configuracion.ConnectionString));

            CargarDatosPaciente();
            panelAgregar.Visible = false;
     
        }

        private void CargarDatosPaciente()
        {
            // Crea una conexión a la base de datos.
            _presenter.ObtenerUsuario("n");
        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }







        private void iconClose_Click_1(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
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
                    DataGridViewRow row = DGVAdministrativo.Rows[e.RowIndex];
                    string dni = row.Cells["dni"].Value.ToString();
                   usuario =_presenter.Buscar(dni );
                    cargarUserControl();
          

                }
            }
        }

        private void cargarUserControl()
        {
            panelAgregar.Visible = true;
            MenuAdminUsuarios ma = new MenuAdminUsuarios();
            panelAgregar.Visible = true;
            ma.Dock = DockStyle.Fill;
            ma.closeclick += closeclick;
            ma.bajaclick += bajaclick;
            ma.editarclick += editarclick;
            panelAgregar.Controls.Clear();
            panelAgregar.Controls.Add(ma);
            ma.BringToFront();
        }

        private void editarclick(object sender, EventArgs e)
        {
            editar_usuario ap = new editar_usuario(usuario);
            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;

                panelOpciones.Controls.Clear();
                panelOpciones.Controls.Add(ap);


            }
        
    }

        private void bajaclick(object sender, EventArgs e)
        {
            if (_presenter.cambiarBaja(usuario))
            {
                MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosPaciente();
                panelAgregar.Visible = false;
            }
            else
            {
                MessageBox.Show("Hubo un problema al editar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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