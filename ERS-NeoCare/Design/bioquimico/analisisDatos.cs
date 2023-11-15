using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{

    public partial class analisisDatos : UserControl
    
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private HistoriaClinicaPresenter _presenter;
        private ArchivoEstudioPresenter _presenterArchivo;
        private AnalisisPresenter _presenterAnalisis;
        private OrdenPresenter _presenterorden;
        private ArchivoEstudio archivo;
        public event EventHandler recargar;
        private ArchivoEstudio archivoEstudio;
        public analisisDatos()
        {
            _presenter = new HistoriaClinicaPresenter( new HistoriaClinicaService(Configuracion.ConnectionString));
            _presenterArchivo = new ArchivoEstudioPresenter(new ArchivoEstudioService(Configuracion.ConnectionString));
            _presenterAnalisis = new AnalisisPresenter(this, new AnalisisService());
            _presenterorden = new OrdenPresenter(new OrdenService());

            InitializeComponent();
            
            labelFechaOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Paciente.Nombre + " " + AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Paciente.Apellido;
            labelPacienteDniOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Medico.NombreApellido;
            labelMedicoMatriculaOrden.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Medico.Matricula.ToString();
            textBoxOrdenIndicaciones.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Orden.Indicaciones;

            labelNumeroAnalisis.Text = AnalisisSingleton.Instance.AnalisisAutenticado.IdAnalisis.ToString();
            labelFechaAnalisis.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Fecha.ToString("dd/MM/yyyy");
            labelAnalisisBioquimico.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.NombreApellido;
            labelAnalisisBioquimicoMatricula.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Usuario.Matricula.ToString();
            labelAnalisisTipo.Text = AnalisisSingleton.Instance.AnalisisAutenticado.TipoAnalisis;
            textBoxObservaciones.Text = AnalisisSingleton.Instance.AnalisisAutenticado.Observaciones;
            cargarArchivos();
        }
        internal void cargarArchivos( )
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

       



     
    

