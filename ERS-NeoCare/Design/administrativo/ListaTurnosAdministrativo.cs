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
            _presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));
            _presenter.ListaTurnos();

        }

        public void cargarDatos(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seleccion = comboBox1.SelectedItem.ToString();
            switch (seleccion)
            {
                case "Atendido":
                    _presenter.ObtenerTurnoEstado(true);
                    break;


                case "No Atendido":
                    _presenter.ObtenerTurnoEstado(false);
                    break;
                case "Todos":
                    _presenter.ListaTurnos();
                    break;
                default:
                    _presenter.ListaTurnos();
                    break;
            }


        }

      


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            _presenter.BuscarTurnoListaTurnoAdm(searchText);
        }

    
    }
}
