using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_paciente : UserControl
    {



        private menu MainForm { get; set; }
        // Declara un evento personalizado para notificar clics en los botones


        public lista_paciente()
        {
            InitializeComponent();
            panelAgregar.Visible = false;
            CargarDatosPaciente();
        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }

        private void CargarDatosPaciente()
        {
            PacienteModel modelo = new PacienteModel(Configuracion.ConnectionString);
            DataTable data = modelo.ObtenerDatosPaciente();
            MostrarDatosPaciente(data);
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
            agregar_paciente ap = new agregar_paciente();
            //ap.closeclick += closeclick();
            cargarUserControl(ap);
        }

        private void closePanel(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }
        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    menuPaciente menu = new menuPaciente();
                    panelAgregar.Visible = true;
                    //menu.closeclick += closeclick();
                    cargarUserControl(menu);

                }
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
        private void closeclick()
        {
            panelAgregar.Visible = false;
        }
    }
}