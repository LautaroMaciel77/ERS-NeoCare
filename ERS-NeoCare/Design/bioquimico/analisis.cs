using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class analisis : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private HistoriaClinicaPresenter _presenter;
        private ArchivoEstudioPresenter _presenterArchivo;
        private AnalisisPresenter _presenterAnalisis;
        private ArchivoEstudio archivo;
        public analisis()
        {
            _presenter = new HistoriaClinicaPresenter( new HistoriaClinicaService(Configuracion.ConnectionString));
            _presenterArchivo = new ArchivoEstudioPresenter(new ArchivoEstudioService(Configuracion.ConnectionString));
            _presenterAnalisis = new AnalisisPresenter(this, new AnalisisService()); 
            InitializeComponent();
        }

 



   

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Verificar si textNombre, textApellido y textDomicilio no están vacíos
            if (string.IsNullOrWhiteSpace(textBoxObservaciones.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (archivo == null || string.IsNullOrWhiteSpace(archivo.NombreArchivo) || string.IsNullOrWhiteSpace(archivo.Ubicacion))
            {
                MessageBox.Show("Por favor, seleccione un archivo válido.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (_presenterArchivo.insertarGeneral(archivo))
            {
                AnalisisModel analisis = new AnalisisModel()
                {
                    Fecha = DateTime.Now,
                    Observaciones = textBoxObservaciones.Text,
                    IdOrden = OrdenSingleton.Instance.OrdenAutenticada.Id,
                    IdUsuario = UsuarioSingleton.Instance.UsuarioAutenticado.id,
                    TipoAnalisis = comboBox1.SelectedItem.ToString(),
                    IdArchivo = ArchivoEstudiosSingleton.Instance.archivoEstudio.Id,


                };
                _presenterAnalisis.Insertar(analisis);
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un archivo válido.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }



        private void iconButtonCargar_Click(object sender, EventArgs e)

        {
            _presenter.Buscar();
            //mover esto a medico
            if (HistoriaClinicaSingleton.Instance.historiaAutenticado == null)
            {
                MessageBox.Show("Error: Debe existir una historia de usuario primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nombrePaciente = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;
            string carpetaPaciente = Path.Combine("recursos", nombrePaciente);

            if (!Directory.Exists(carpetaPaciente))
            {
                Directory.CreateDirectory(carpetaPaciente);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = Path.GetFileName(openFileDialog.FileName);
                string rutaArchivoDestino = Path.Combine(carpetaPaciente, nombreArchivo);
                string rutaArchivoOrigen = openFileDialog.FileName;

                // Verifica si el archivo ya existe en la lista
                if (!ArchivoExistenteEnLista(nombreArchivo))
                {
                    // Verifica si el archivo es un PDF
                    if (EsArchivoPDF(rutaArchivoOrigen))
                    {
                        // Preguntar al usuario si está seguro de insertar el archivo
                        DialogResult result = MessageBox.Show("¿Está seguro de insertar el archivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                File.Copy(rutaArchivoOrigen, rutaArchivoDestino, true);

                                // Aquí llamamos a la función de inserción en lugar de agregar el archivo a la lista
                                 archivo = new ArchivoEstudio { NombreArchivo = nombreArchivo, Ubicacion = rutaArchivoDestino };
                        
                                ListViewItem item = new ListViewItem(nombreArchivo);
                                listViewArchivos.Items.Add(item);

                            }
                            catch (Exception ex)
                            {
                                // Agregar mensaje de depuración para mostrar cualquier error
                                MessageBox.Show("Error al copiar el archivo: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado no es un archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" ya existe un archivo en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool ArchivoExistenteEnLista(string nombreArchivo)
        {
            foreach (ListViewItem item in listViewArchivos.Items)
            {
                if (item.Text == nombreArchivo && item.SubItems.Count == 1)
                {
                    return true; // El archivo ya existe en la lista y solo tiene un archivo
                }
            }
            return false; // El archivo no existe en la lista o tiene más de un archivo
        }

            private bool EsArchivoPDF(string rutaArchivo)
        {
            string extension = Path.GetExtension(rutaArchivo);
            return extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase);
        }
    }
}

     
    

