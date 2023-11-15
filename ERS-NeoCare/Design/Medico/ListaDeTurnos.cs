using ERS_NeoCare.Design.Medico;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace ERS_NeoCare.Design
{
    public partial class ListaDeTurnos : UserControl
    {
        private TurnoPresenter _presenter;
        private PacientePresenter _pacientePresenter;
        public ListaDeTurnos()
        {
            InitializeComponent();
            _presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));
            _pacientePresenter = new PacientePresenter(new Presenter.PacienteService(Configuracion.ConnectionString));
            _presenter.CargarPacienteAtendidos();

        }
        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }
        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {


                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    string dniPaciente = DGVAdministrativo.Rows[e.RowIndex].Cells["PacienteDni"].Value.ToString();
                    _pacientePresenter.cargarPaciente(dniPaciente);
                    verPaciente();
                } 
            } 
        }

        private void verPaciente()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;

            _presenter.BuscarPacienteAtendido(searchText);
        }
    }
}
   
