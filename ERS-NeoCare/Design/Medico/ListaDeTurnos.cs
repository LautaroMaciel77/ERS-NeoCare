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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;

            _presenter.BuscarPacienteAtendido(searchText);
        }
    }
}
   
