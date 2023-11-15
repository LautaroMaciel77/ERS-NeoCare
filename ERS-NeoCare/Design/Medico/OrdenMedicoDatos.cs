
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

            labelNumeroOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Id.ToString(); 
            labelOrdenFecha.Text = OrdenSingleton.Instance.OrdenAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelOrdenTipo.Text = OrdenSingleton.Instance.OrdenAutenticada.TipoOrden;
            labelOrdenUrgencia.Text = OrdenSingleton.Instance.OrdenAutenticada.Urgencia ? "Si" : "No";
            labelOrdenMedico.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.NombreApellido;
            labelOrdenPaciente.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Paciente.Apellido;
            labelOrdenPacienteDni.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Dni.ToString();
            textBoxOrdenIndicaciones.Text = OrdenSingleton.Instance.OrdenAutenticada.Indicaciones;

            // condicion de analisis o atencion

            if ( OrdenSingleton.Instance.OrdenAutenticada.TipoOrden == "Analisis") {
                panelAnalisis.Visible = true;
                panelAtencion.Visible = false;
                labelAnalisisNumero.Text = AnalisisSingleton.Instance.AnalisisAutenticado.IdAnalisis.ToString();
                labelAnalisisFecha.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Fecha.ToString("dd/MM/yyyy");
                labelAnalisisBioquimico.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.NombreApellido;
                labelAnalisisBioquimicoMatricula.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.Matricula.ToString();
                labelAnalisisTipo.Text = AnalisisSingleton.Instance.AnalisisAutenticado.TipoAnalisis;
                textBoxAnalisisObservaciones.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Observaciones;
                
            }
            else {
                panelAnalisis.Visible = false;
                panelAtencion.Visible = true;
                labelAtencionNumero.Text = AtencionSingleton.Instance.AtencionAutenticada.IdAtencion.ToString();
                labelAtencionFecha.Text = AtencionSingleton.Instance.AtencionAutenticada.Fecha.ToString("dd/MM/yyyy");
                labelAtencionEnfermero.Text = AtencionSingleton.Instance.AtencionAutenticada.Usuario.NombreApellido;
                labelAtencionEnfermeroMatricula.Text = AtencionSingleton.Instance.AtencionAutenticada.Usuario.Matricula.ToString();
                textBoxAtencionIndicaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Indicaciones;
                textAtencionObservaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Observaciones;
            }
        }
    }
}
