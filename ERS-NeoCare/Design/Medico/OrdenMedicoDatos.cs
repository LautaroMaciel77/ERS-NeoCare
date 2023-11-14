
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class OrdenMedicoDatos : UserControl
    {
        private DateTime select;
        private string dni;
        private string rangoHora;
        private bool urgencia;
        private OrdenPresenter presenter;
        private HistoriaClinicaPresenter historiaClinicaPresenter;
        public OrdenMedicoDatos()
        {
            InitializeComponent();

            presenter = new OrdenPresenter( new OrdenService());
            historiaClinicaPresenter = new HistoriaClinicaPresenter(new HistoriaClinicaService(Configuracion.ConnectionString));

          //  labelFechaEvaluacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
         //   labelPacienteEvaluacion.Text = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;

        }



           

   
 
      
    }
}
