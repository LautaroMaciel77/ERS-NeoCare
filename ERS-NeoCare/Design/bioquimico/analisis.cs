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
    public partial class analisis : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
        private HistoriaClinicaPresenter _presenter;
        private ArchivoEstudioPresenter _presenterArchivo;
        private AnalisisPresenter _presenterAnalisis;
        private OrdenPresenter _presenterorden;
        private ArchivoEstudio archivo;
        public event EventHandler recargar;
        private historialPresenter _presenterHistorial;
        private TipoAnalisisPresenter _presenterTipoAnalisis;

        public analisis()
        {
            _presenter = new HistoriaClinicaPresenter( new HistoriaClinicaService(Configuracion.ConnectionString));
            _presenterArchivo = new ArchivoEstudioPresenter(new ArchivoEstudioService(Configuracion.ConnectionString));
            _presenterAnalisis = new AnalisisPresenter(this, new AnalisisService());
            _presenterorden = new OrdenPresenter(new OrdenService());
            _presenterHistorial = new historialPresenter(new HistorialService());
            _presenterTipoAnalisis = new TipoAnalisisPresenter(new TipoAnalisisService());
            InitializeComponent();

            labelFechaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.FechaCreacion.ToString("dd/MM/yyyy");
            labelPacienteNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Paciente.Apellido;
            labelPacienteDniOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Paciente.Dni.ToString();
            labelMedicoNombreOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Nombre + " " + OrdenSingleton.Instance.OrdenAutenticada.Medico.Apellido;
            labelMedicoMatriculaOrden.Text = OrdenSingleton.Instance.OrdenAutenticada.Medico.Matricula.ToString();

            textBoxOrdenIndicaciones.Text = OrdenSingleton.Instance.OrdenAutenticada.Indicaciones;
       
            List<TipoAnalisModel> tiposAnalisis = _presenterTipoAnalisis.ObtenerTiposAnalisis();


            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = tiposAnalisis;
        }

 



   

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            TipoAnalisModel tipoSeleccionado = (TipoAnalisModel)comboBox1.SelectedItem;

            // Verificar si se seleccionó un elemento
            if (tipoSeleccionado == null)
            {

                MessageBox.Show("Por favor, seleccione un tipo analisis.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            



        }
            string descripcionSeleccionada = tipoSeleccionado.descripcion;
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
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de análisis.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    TipoAnalisis = descripcionSeleccionada,
                    IdArchivo = ArchivoEstudiosSingleton.Instance.archivoEstudio.Id,


                };
                _presenterAnalisis.Insertar(analisis);
                _presenterorden.cambiarEstado(OrdenSingleton.Instance.OrdenAutenticada.Id);

                HistorialModel historialModel = new HistorialModel()
                {
                    Id = AnalisisSingleton.Instance.AnalisisAutenticado.IdAnalisis,
                    Tipo = "Analisis",
                    fecha = DateTime.Now,
                    IdAtencion =null,
                    IdPaciente = PacienteSingleton.Instance.pacienteAutenticado.Id,
                    IdMedico = UsuarioSingleton.Instance.UsuarioAutenticado.id,
                    IdEvaluacion = null,
                    IdAnalisis = AnalisisSingleton.Instance.AnalisisAutenticado.IdAnalisis,


                };
                _presenterHistorial.Insertar(historialModel);
         

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

            if (listViewArchivos.Items.Count > 0)
            {
                // Si ya hay un archivo en la lista
                string archivoExistente = ArchivoExistenteEnLista();
                DialogResult result = MessageBox.Show($"Ya existe un archivo ({archivoExistente}) en la lista. ¿Desea sobrescribirlo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Elimina el archivo existente de la lista y del directorio
                    EliminarArchivoExistente(archivoExistente);
                }
                else
                {
                    return; // No se permite insertar otro archivo si ya hay uno y el usuario no quiere sobrescribirlo
                }
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

        private string ArchivoExistenteEnLista()
        {
            if (listViewArchivos.Items.Count > 0)
            {
                ListViewItem item = listViewArchivos.Items[0];
                return item.Text;
            }

            return null;
        }

        private void EliminarArchivoExistente(string nombreArchivo)
        {
            string carpetaPaciente = ObtenerCarpetaPaciente();
            string rutaArchivoExistente = Path.Combine(carpetaPaciente, nombreArchivo);

            try
            {
                // Elimina el archivo existente de la lista
                listViewArchivos.Items.Clear();

                // Elimina el archivo existente del directorio
                File.Delete(rutaArchivoExistente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el archivo existente: " + ex.Message);
            }
        }

        private string ObtenerCarpetaPaciente()
        {
            string nombrePaciente = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;
            return Path.Combine("recursos", nombrePaciente);
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
        internal void mensaje(string v)
        {
            MessageBox.Show(v, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            volver();
        }

        private void volver()
        {
            lista_paciente_enfermero pacienteControl = new lista_paciente_enfermero();
            pacienteControl.Dock = DockStyle.Fill;

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                panelOpciones.Controls.Clear();


                panelOpciones.Controls.Add(pacienteControl);




            }
            recargar?.Invoke(this, EventArgs.Empty);
        }
    }

}

     
    

