using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_paciente : UserControl
    {



        private menu MainForm { get; set; }
        // Declara un evento personalizado para notificar clics en los botones

        public string dni;
       
        public PacienteModel paciente;
        private PacientePresenter _presenter;
        public lista_paciente()
        {
            InitializeComponent();
            panelAgregar.Visible = false;
            _presenter = new PacientePresenter(this, new PacienteService(Configuracion.ConnectionString));

            CargarDatosPaciente();
        }

        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }


        private void CargarDatosPaciente()
        {
            PacienteService modelo = new PacienteService(Configuracion.ConnectionString);
            DataTable data = modelo.ObtenerDatosPaciente();
            MostrarDatosPaciente(data);
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
            agregar_paciente ap = new agregar_paciente();
            ap.closeagregarclick += closeagregarclick;
            ap.actualizarTabla += Ap_actualizarTabla;
            cargarUserControl(ap);
        }

        private void Ap_actualizarTabla(object sender, EventArgs e)
        {
            CargarDatosPaciente();
        }

        private void closeagregarclick(object sender, EventArgs e)
        {

            panelAgregar.Visible = false;
        }

    

        public void MostrarMenu(PacienteModel paciente)
        {
            panelAgregar.Visible = true;
            menuPaciente mp = new menuPaciente();
            this.paciente = paciente;
            mp.closeclick += closeclick;
            mp.verclick += verclick;
            cargarUserControl(mp);
        }

        private void verclick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void verpacienteclick()
        {
            
              //PacienteView pacienteControl = new PacienteView(paciente);
                //pacienteControl.Dock = DockStyle.Fill; // Ajusta el control al tamaño del panelOpciones

                // Accede al formulario 'menu' desde el control actual
                //menu menuForm = this.ParentForm as menu;

                //if (menuForm != null)
                //{
                 //   Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;


                    // Borra cualquier control existente en el panelOpciones
                   // panelOpciones.Controls.Clear();

                    // Agrega el control PacienteView al panelOpciones
                   // panelOpciones.Controls.Add(pacienteControl);
                    // Llama al método para agregar el control al panelOpciones



                //}

        }

        private void closeclick(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
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
                    int columnIndexDNI = 0;
                    this.dni = DGVAdministrativo.Rows[e.RowIndex].Cells[columnIndexDNI].Value.ToString();
                    _presenter.cargarMenu();
               
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