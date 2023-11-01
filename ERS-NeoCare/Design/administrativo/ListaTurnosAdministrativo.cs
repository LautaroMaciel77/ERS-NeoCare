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

namespace ERS_NeoCare.Design.administrativo
{
    public partial class ListaTurnosAdministrativo : UserControl
    {
        private TurnoPresenter _presenter;
        public ListaTurnosAdministrativo()
        {
            InitializeComponent();
            cargarDatos();
            _presenter = new TurnoPresenter(new TurnoService(Configuracion.ConnectionString));
        }

        private void cargarDatos()
        {
            DGVAdministrativo.DataSource=_presenter.ListaTurnos();
        }

   
  
        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
