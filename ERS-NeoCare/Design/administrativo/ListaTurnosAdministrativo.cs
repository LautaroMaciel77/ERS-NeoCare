using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class ListaTurnosAdministrativo : UserControl
    {
        private TurnoPresenter _presenter;
        public ListaTurnosAdministrativo()
        {
            InitializeComponent();
            _presenter = new TurnoPresenter(this,new TurnoService(Configuracion.ConnectionString));
            _presenter.ListaTurnos();

        }

        public void cargarDatos(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }
        

   
  
        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seleccion = comboBox1.SelectedItem.ToString();
            switch (seleccion)
            {
                case "Atendido":
                    _presenter.ObtenerTurnoEstado("s");
                    break;

       
                case "No Atendido":
                    _presenter.ObtenerTurnoEstado("n");
                    break;
                case "Todos":
                    _presenter.ListaTurnos();
                    break;
                default:
                    _presenter.ListaTurnos();
                    break;
            }

           
        }

        private void DGVAdministrativo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna actual corresponde a la columna de imagen "EstadoTurnoColumn" por su nombre
            if (DGVAdministrativo.Columns[e.ColumnIndex].Name == "EstadoTurnoColumn" && e.RowIndex >= 0)
            {
                // Accede al valor de la columna "Estado" en la misma fila
                var estadoCellValue = DGVAdministrativo.Rows[e.RowIndex].Cells["Estado"].Value;

                if (estadoCellValue != null)
                {
                    string estado = estadoCellValue.ToString();

                    if (estado == "s")
                    {
                        // Establece la imagen "activo" cuando el estado es "s"
                        //e.Value = Properties.Resources.ActivoImage; // Reemplaza con tu imagen activa
                    }
                    else if (estado == "n")
                    {
                        // Establece la imagen "inactivo" cuando el estado es "n"
                       // e.Value = Properties.Resources.InactivoImage; // Reemplaza con tu imagen inactiva
                    }
                }
            }
        }
    }
}
