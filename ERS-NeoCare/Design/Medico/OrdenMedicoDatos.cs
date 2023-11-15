
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
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
        private AtencionPresenter _presenterAtencion;
        private ArchivoEstudioPresenter _presenterArchivo;
        private AnalisisPresenter _presenterAnalisis;
        public OrdenMedicoDatos()
        {
            InitializeComponent();

            presenter = new OrdenPresenter( new OrdenService());
            historiaClinicaPresenter = new HistoriaClinicaPresenter(new HistoriaClinicaService(Configuracion.ConnectionString));
            _presenterAtencion = new AtencionPresenter(new AtencionService());
            _presenterArchivo = new ArchivoEstudioPresenter(new ArchivoEstudioService(Configuracion.ConnectionString));
            _presenterAnalisis = new AnalisisPresenter(new AnalisisService());


            cargarLabel();
            cargarTipoOrden();
          

            // condicion de analisis o atencion

        }

        private void cargarTipoOrden()
        {
            AnalisisSingleton.Instance.DesautenticarAnalisis();
            AtencionSingleton.Instance.DesautenticarAnalisis();
            if (OrdenSingleton.Instance.OrdenAutenticada.TipoOrden == "Analisis")
            {
           
                if (_presenterAnalisis.buscaryRemplazarIdOrden(OrdenSingleton.Instance.OrdenAutenticada.Id))
                {
                if(AnalisisSingleton.Instance.AnalisisAutenticado == null)
                    {
                        return;
                    }
                    panelAnalisis.Visible = true;
                    panelAtencion.Visible = false;
                    labelAnalisisNumero.Text = AnalisisSingleton.Instance.AnalisisAutenticado.IdAnalisis.ToString();
                    labelAnalisisFecha.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Fecha.ToString("dd/MM/yyyy");
                    labelAnalisisBioquimico.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.Nombre +"" + AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.Apellido;
                    labelAnalisisBioquimicoMatricula.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.Matricula.ToString();
                    labelAnalisisTipo.Text = AnalisisSingleton.Instance.AnalisisAutenticado.TipoAnalisis;
                    textBoxAnalisisObservaciones.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Observaciones;
                    cargarArchivos();

                }
            }
            else
            {
             
                if (_presenterAtencion.buscaryRemplazarIdOrden(OrdenSingleton.Instance.OrdenAutenticada.Id))
                {
                    panelAnalisis.Visible = false;
                    panelAtencion.Visible = true;
                    labelAtencionNumero.Text = AtencionSingleton.Instance.AtencionAutenticada.IdAtencion.ToString();
                    labelAtencionFecha.Text = AtencionSingleton.Instance.AtencionAutenticada.Fecha.ToString("dd/MM/yyyy");
                    labelAtencionEnfermero.Text = AtencionSingleton.Instance.AtencionAutenticada.Usuario.Nombre+" " + AtencionSingleton.Instance.AtencionAutenticada.Usuario.Apellido;
                    labelAtencionEnfermeroMatricula.Text = AtencionSingleton.Instance.AtencionAutenticada.Usuario.Matricula.ToString();
            
                    textBoxAtencionIndicaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Indicaciones;
                    textAtencionObservaciones.Text = AtencionSingleton.Instance.AtencionAutenticada.Observaciones;
                }
            }
        }

        private void cargarLabel()
        {
            labelNumeroOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Id.ToString();
            labelOrdenFecha.Text = OrdenSingleton.Instance.OrdenAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelOrdenTipo.Text = OrdenSingleton.Instance.OrdenAutenticada.TipoOrden;
            labelOrdenUrgencia.Text = OrdenSingleton.Instance.OrdenAutenticada.Urgencia ? "Si" : "No";
            labelOrdenMedico.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.NombreApellido;
            labelOrdenPaciente.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Paciente.Apellido;
            labelOrdenPacienteDni.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Dni.ToString();
            textBoxOrdenIndicaciones.Text = OrdenSingleton.Instance.OrdenAutenticada.Indicaciones;
            labelOrdenMedicoMatricula.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Matricula.ToString();
        }
        internal void cargarArchivos()
        {




            int? idArchivo = AnalisisSingleton.Instance.AnalisisAutenticado?.IdArchivo;

            if (idArchivo.HasValue)
            {

                _presenterArchivo.cargarArchivo(idArchivo.Value);


                listViewArchivos.Items.Clear();


                listViewArchivos.Items.Add(new ListViewItem(ArchivoEstudiosSingleton.Instance.archivoEstudio.NombreArchivo));
            }
            else
            {

                MessageBox.Show("No hay Archivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (listViewArchivos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewArchivos.SelectedItems[0];
                string nombreArchivo = selectedItem.Text;
                string rutaArchivo = ObtenerRutaDelArchivo(nombreArchivo);

                if (!string.IsNullOrEmpty(rutaArchivo))
                {
                    // Verifica si el archivo es un PDF
                    if (EsArchivoPDF(rutaArchivo))
                    {
                        // Abre el PDF usando Pdfium o el visor de PDF predeterminado
                        MostrarPDF(rutaArchivo);
                    }
                    else
                    {
                        MessageBox.Show("Este no es un archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un archivo para abrir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string ObtenerRutaDelArchivo(string nombreArchivo)
        {



            if (ArchivoEstudiosSingleton.Instance.archivoEstudio.NombreArchivo == nombreArchivo)
            {
                return ArchivoEstudiosSingleton.Instance.archivoEstudio.Ubicacion;
            }
            else
            {
                return null;
            }
        }
        private bool EsArchivoPDF(string rutaArchivo)
        {
            string extension = Path.GetExtension(rutaArchivo);
            return extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase);
        }

        private void MostrarPDF(string rutaPDF)
        {

            try
            {
                Process.Start(rutaPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

