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


  
        public UsuarioModel usuario = new UsuarioModel();
        private UsuarioPresenter _presenter;
        private menu MainForm { get; set; }


        public lista_baja_usuarios()
        {

            InitializeComponent();
            _presenter = new UsuarioPresenter(this, new UsuarioService(Configuracion.ConnectionString));

            CargarDatos();
            panelAgregar.Visible = false;
     
        }

        private void CargarDatos()
        {
            // Crea una conexión a la base de datos.
            _presenter.ObtenerUsuarioBaja("s");
        }

        public void MostrarDatos(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }







        private void iconClose_Click_1(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }

   

        private void DGVAdministrativo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    DataGridViewRow row = DGVAdministrativo.Rows[e.RowIndex];
                    string dni = row.Cells["dni"].Value.ToString();
                   _presenter.Buscar(dni);
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
            ma.editarclick += editarClick;
            panelAgregar.Controls.Clear();
            panelAgregar.Controls.Add(ma);
            ma.BringToFront();
        }

        private void editarClick(object sender, EventArgs e)
        {
            editar_usuario ap = new editar_usuario();
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
            if (_presenter.cambiarBaja())
            {
                MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
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

   


    }
}