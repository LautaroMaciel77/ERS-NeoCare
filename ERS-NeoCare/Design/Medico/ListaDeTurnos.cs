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
        private menu MainForm { get; set; }
        private string userDni;
        public event EventHandler<Tuple<string>> TurnoMedicoClick;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        // private TurnoMedico _presenter;
        private TurnoPresenter _presenter;
        public ListaDeTurnos()
        {
            InitializeComponent();
            _presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));
            _presenter.ListaTurnoMedicos();
            //_presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));


        }

        internal void cargarDatosPaciente(List<Turno> data)

        {

            DGVAdministrativo.DataSource = data;


           // buttonColumn.UseColumnTextForButtonValue = true; // Esto muestra el texto en lugar del botón por defecto

            // Agregar la columna de botón al DataGridView


        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            _presenter.BuscarTurnoListaTurnoMedico(searchText);
        }



        //}

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVAdministrativo.Rows.Count > 0)
            {
                if (DGVAdministrativo.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int columnIndexID = 0;
                    int turnoId = (int)DGVAdministrativo.Rows[e.RowIndex].Cells[1].Value;

                    _presenter.cambiarEstado(turnoId);

                    // Obtener la celda de estado
                    DataGridViewCell estadoCell = DGVAdministrativo.Rows[e.RowIndex].Cells["estado"];

                    // Obtener la imagen actual
                    Image estadoImage = estadoCell.Value as Image;

                    // Invertir la imagen en función del estado actual
                    if (estadoImage == Properties.Resources.check_box_FILL)
                    {
                        estadoImage = Properties.Resources.check_box_blank;
                    }
                    else
                    {
                        estadoImage = Properties.Resources.check_box_FILL;
                    }

                    // Refrescar la celda para asegurarte de que se muestre la nueva imagen
                    DGVAdministrativo.InvalidateCell(estadoCell);

                }
            }
        }
    }
}
   
