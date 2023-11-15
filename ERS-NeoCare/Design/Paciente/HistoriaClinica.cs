using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ImprmirPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static ImprmirPdf.ContenidoHTML;

namespace ERS_NeoCare.Design.Paciente
{
    public partial class HistoriaClinica : UserControl
    {
        private HistoriaClinicaPresenter _presenter;
        private ArchivoEstudioPresenter _presenterArchivo;
        private EvaluacionPresenter _presenterEvaluacion;

        string tipoEditar;
        private Dictionary<string, ListView> listViews = new Dictionary<string, ListView>();
        bool editarflag;
        private string sangre;
        List<ArchivoEstudio> archivos = new List<ArchivoEstudio>();
        List<ArchivoEstudio> archivosEliminar = new List<ArchivoEstudio>();
        private historialPresenter _presenterHM;
        private AnalisisPresenter _presenterAnalisis;
        private AtencionPresenter _presenterAtencion;
        private OrdenPresenter _presenterOrden;
     
        public HistoriaClinica()
        {
            InitializeComponent();
            _presenter = new HistoriaClinicaPresenter(this, new HistoriaClinicaService(Configuracion.ConnectionString));
            _presenterArchivo = new ArchivoEstudioPresenter(this, new ArchivoEstudioService(Configuracion.ConnectionString));
            _presenterHM = new historialPresenter(this, new HistorialService());
            _presenterEvaluacion = new EvaluacionPresenter(new EvaluacionService());
            _presenterAnalisis = new AnalisisPresenter(new AnalisisService());
            _presenterAtencion = new AtencionPresenter( new AtencionService());
            _presenterOrden = new OrdenPresenter(new OrdenService());
            CargarDatos();
            _presenterHM.TraerHistorial();
            panel1.Visible = false;

            // Agrega los ListView al diccionario
            listViews["Familiar"] = listViewFamiliares;
            listViews["Alergia"] = listViewAlergias;
            listViews["Medico"] = listViewMedicamentos;

        }
        internal void CargarHistorial(DataTable data)
        {
            dataGridView1.DataSource = data;
        }
        internal void CargarDatos()
        {

            if (HistoriaClinicaSingleton.Instance.historiaAutenticado == null)
            {
                labelDatoMatricula.Text = UsuarioSingleton.Instance.UsuarioAutenticado.Matricula.ToString();
                labelDatoFechaInicio.Text = DateTime.Now.ToString("dd/MM/yy");
                labelDatoNombre.Text = UsuarioSingleton.Instance.UsuarioAutenticado.Nombre + " " + UsuarioSingleton.Instance.UsuarioAutenticado.Apellido;

                return;
            }
            if (UsuarioSingleton.Instance.UsuarioAutenticado.ProfesionID != 3)
            {

                btnEditMedicamentos.Visible = false;
                btnEditFamiliares.Visible = false;
                btnAlergias.Visible = false;
                btnBorrarArchivo.Visible = false;
                comboBox1.Enabled = false;
                btnGuardar.Visible = false;
                btnCargarArchivo.Visible = false;


            }

            labelDatoMatricula.Text = HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Matricula.ToString();
            labelDatoFechaInicio.Text = HistoriaClinicaSingleton.Instance.historiaAutenticado.FechaInicio.ToString("dd/MM/yy");
            labelDatoNombre.Text = HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Nombre + " " + UsuarioSingleton.Instance.UsuarioAutenticado.Apellido;
            comboBox1.SelectedItem = HistoriaClinicaSingleton.Instance.historiaAutenticado.TipoSangre;
            //comboBox1.SelectedValue = HistoriaClinicaSingleton.Instance.historiaAutenticado.TipoSangre;
            //usar presenter aca
            string alergias = HistoriaClinicaSingleton.Instance.historiaAutenticado.Alergias;
            CargarListViewDesdeCadena(alergias, listViewAlergias);

            string familiares = HistoriaClinicaSingleton.Instance.historiaAutenticado.Familiares;
            CargarListViewDesdeCadena(familiares, listViewFamiliares);

            string medicamentos = HistoriaClinicaSingleton.Instance.historiaAutenticado.Medicamentos;
            CargarListViewDesdeCadena(medicamentos, listViewMedicamentos);
            _presenterArchivo.cargarArchivos();


        }
        private void CargarListViewDesdeCadena(string datos, ListView listView)
        {
            string[] elementos = datos.Split(';'); // Divide la cadena en una matriz de cadenas

            // Limpia el ListView antes de agregar los elementos
            listView.Items.Clear();

            foreach (string elemento in elementos)
            {
                // Agrega cada elemento al ListView
                listView.Items.Add(new ListViewItem(elemento));
            }
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            tipoEditar = "Familiar";
            panel1.Visible = true;

        }

        private void CargarListView()
        {
            string contenido = textBoxContenido.Text;
            if (string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("El contenido no puede estar vacío.");
                panel1.Visible = false;
                return;
            }
            if (editarflag)
            {
                panel1.Visible = false;

                ListView listView = listViews[tipoEditar];

                // Verifica si hay elementos seleccionados en el ListView
                if (listView.SelectedItems.Count == 1)
                {
                    // Obtiene el elemento seleccionado
                    ListViewItem selectedItem = listView.SelectedItems[0];

                    // Actualiza el elemento con el nuevo contenido del TextBox
                    selectedItem.Text = textBoxContenido.Text;
                    textBoxContenido.Clear();
                    MessageBox.Show("edicion con exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                else
                {
                    MessageBox.Show("problema al editar vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return;

            }


            switch (tipoEditar)
            {
                case "Familiar":
                    ListViewItem item = new ListViewItem(contenido);
                    listViewFamiliares.Items.Add(item);
                    textBoxContenido.Clear();
                    break;
                    ;

                case "Alergia":

                    ListViewItem itemAlergia = new ListViewItem(contenido);
                    listViewAlergias.Items.Add(itemAlergia);
                    textBoxContenido.Clear();
                    break;

                case "Medico":
                    ListViewItem itemMedicamento = new ListViewItem(contenido);
                    listViewMedicamentos.Items.Add(itemMedicamento);
                    textBoxContenido.Clear();

                    break;

                default:
                    // Manejar otro caso si es necesario
                    break;

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tipoEditar = "Medico";
            panel1.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            tipoEditar = "Alergia";
            panel1.Visible = true;
        }







        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            string descripcionCompletaAlergias = string.Join(";", listViewAlergias.Items.Cast<ListViewItem>().Select(item => item.Text));
            string descripcionCompletaFamiliares = string.Join(";", listViewFamiliares.Items.Cast<ListViewItem>().Select(item => item.Text));
            string descripcionCompletaMedicamentos = string.Join(";", listViewMedicamentos.Items.Cast<ListViewItem>().Select(item => item.Text));

            if (string.IsNullOrEmpty(sangre))
            {
                MessageBox.Show("Asegúrate de seleccionar un tipo de sangre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HistoriaClinicaModel historiaClinica = new HistoriaClinicaModel
            {
                Alergias = descripcionCompletaAlergias,
                Medicamentos = descripcionCompletaMedicamentos,
                Familiares = descripcionCompletaFamiliares,
                TipoSangre = sangre,
                IdPaciente = PacienteSingleton.Instance.pacienteAutenticado.Id,
                IdUsuario = UsuarioSingleton.Instance.UsuarioAutenticado.id,
            };

            if (HistoriaClinicaSingleton.Instance.historiaAutenticado == null)
            {

                _presenter.Insertar(historiaClinica, archivos);
            }
            else
            {

                _presenter.Actualizar(historiaClinica);
            }

        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            CargarListView();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tipoEditar) && listViews.ContainsKey(tipoEditar))
            {
                ListView listView = listViews[tipoEditar];

                // Verifica si hay elementos seleccionados en el ListView
                if (listView.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("¿Seguro que deseas eliminar el elemento seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Elimina el elemento seleccionado
                        foreach (ListViewItem item in listView.SelectedItems)
                        {
                            listView.Items.Remove(item);
                        }
                        MessageBox.Show("Borrado exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un elemento para eliminar en " + tipoEditar);
                }
            }
            panel1.Visible = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tipoEditar) && listViews.ContainsKey(tipoEditar))
            {
                ListView listView = listViews[tipoEditar];

                // Verifica si hay elementos seleccionados en el ListView
                if (listView.SelectedItems.Count == 1)
                {
                    // Obtiene el elemento seleccionado
                    ListViewItem selectedItem = listView.SelectedItems[0];

                    // Muestra el contenido seleccionado en el TextBox para edición
                    textBoxContenido.Text = selectedItem.Text;
                    MessageBox.Show("Para guardar la edicion aprete el boton guardar.");
                    editarflag = true;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un único elemento para editar.");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sangre = comboBox1.SelectedItem.ToString();

        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (HistoriaClinicaSingleton.Instance.historiaAutenticado == null)
            {

                MessageBox.Show("Error: Debe crear una historia de usuario primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                if (!archivos.Any(a => a.NombreArchivo == nombreArchivo))
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
                                ArchivoEstudio archivo = new ArchivoEstudio { NombreArchivo = nombreArchivo, Ubicacion = rutaArchivoDestino };
                                _presenterArchivo.insertar(archivo);
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
                    MessageBox.Show("El archivo ya existe en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        private void btnBorrarArchivo_Click(object sender, EventArgs e)
        {


            string nombrePaciente = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;
            string carpetaPaciente = Path.Combine("recursos", nombrePaciente);


            if (listViewArchivos.SelectedItems.Count > 0)
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar los archivos seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listViewArchivos.SelectedItems)
                    {
                        string nombreArchivo = item.Text; // Obtiene el nombre del archivo seleccionado en el ListView

                        // Combina la carpeta del paciente con el nombre del archivo para obtener la ruta completa
                        string rutaArchivo = Path.Combine(carpetaPaciente, nombreArchivo);

                        if (File.Exists(rutaArchivo))
                        {
                            try
                            {
                                File.Delete(rutaArchivo); // Intenta eliminar el archivo

                                // Elimina el elemento del ListView
                                listViewArchivos.Items.Remove(item);

                                // Busca el archivo correspondiente en la lista "archivos" y agrégalo a "archivosEliminar"
                                ArchivoEstudio archivoAEliminar = archivos.FirstOrDefault(a => a.NombreArchivo == nombreArchivo);
                                if (archivoAEliminar != null)
                                {
                                    archivosEliminar.Add(archivoAEliminar);

                                    archivos.Remove(archivoAEliminar); // Elimina de la lista principal "archivos"
                                }
                            }
                            catch (IOException ex)
                            {
                                // Maneja la excepción si ocurre un error al eliminar el archivo
                                MessageBox.Show("Error al eliminar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // El archivo no existe, muestra un mensaje de error
                            MessageBox.Show("El archivo no existe: " + nombreArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    _presenterArchivo.Borrar(archivosEliminar);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un archivo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        internal void mensaje(string v)
        {
            MessageBox.Show(v, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void cargarArchivos()
        {
            List<ArchivoEstudio> archivosEstudioList = ArchivoEstudiosSingleton.Instance.archivosEstudio; // Obtiene la lista de archivos desde tu fuente de datos
            archivos = archivosEstudioList;
            listViewArchivos.Items.Clear(); // Limpia el ListView antes de cargar los elementos

            foreach (ArchivoEstudio archivo in archivosEstudioList)
            {
                // Agrega el nombre del archivo al ListView
                listViewArchivos.Items.Add(new ListViewItem(archivo.NombreArchivo));
            }

        }
        private string ObtenerRutaDelArchivo(string nombreArchivo)
        {


            ArchivoEstudio archivo = archivos.FirstOrDefault(a => a.NombreArchivo == nombreArchivo);
            if (archivo != null)
            {
                return archivo.Ubicacion;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonClose_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tipoEditar) && listViews.ContainsKey(tipoEditar))
            {
                ListView listView = listViews[tipoEditar];

                // Verifica si hay elementos seleccionados en el ListView
                if (listView.SelectedItems.Count == 1)
                {
                    // Obtiene el elemento seleccionado
                    ListViewItem selectedItem = listView.SelectedItems[0];

                    // Muestra el contenido seleccionado en el TextBox para edición
                    textBoxContenido.Text = selectedItem.Text;
                    MessageBox.Show("Para guardar la edicion aprete el boton guardar.");
                    editarflag = true;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un único elemento para editar.");
                }
            }
        }

        private void iconButtonBorrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tipoEditar) && listViews.ContainsKey(tipoEditar))
            {
                ListView listView = listViews[tipoEditar];

                // Verifica si hay elementos seleccionados en el ListView
                if (listView.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("¿Seguro que deseas eliminar el elemento seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Elimina el elemento seleccionado
                        foreach (ListViewItem item in listView.SelectedItems)
                        {
                            listView.Items.Remove(item);
                        }
                        MessageBox.Show("Borrado exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un elemento para eliminar en " + tipoEditar);
                }
            }
            panel1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonImprimir_Click(object sender, EventArgs e)
        {
            // cargar historial singleton
            _presenterHM.buscar(PacienteSingleton.Instance.pacienteAutenticado.Id);
            // Genera el contenido HTML y CSS
            string contenidoHTML = ContenidoHTML.ObtenerContenidoHTML();
            string estilosCSS = EstilosCSS.ObtenerEstilosCSS();

            try
            {
                // Crea un archivo temporal con extensión .html y escribe el contenido HTML
                string tempFilePath = Path.Combine(Path.GetTempPath(), "Historia-Clinica.html");
                string estilosFilePath = Path.Combine(Path.GetTempPath(), "estilos.css");
                string imagenTemporalPath = Path.Combine(Path.GetTempPath(), "logo_hospital_eloisa_torrent.jpg");

                // Guarda la imagen temporal directamente
                GuardarImagenTemporal(imagenTemporalPath);

                File.WriteAllText(tempFilePath, contenidoHTML);
                File.WriteAllText(estilosFilePath, estilosCSS);

                // Abre el archivo HTML en el navegador web predeterminado
                Process.Start(new ProcessStartInfo(tempFilePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la Historia Clinica en el navegador: " + ex.Message);
            }
        }

        private static void GuardarImagenTemporal(string rutaImagenTemporal)
        {
            // Reemplaza la siguiente línea con la lógica para obtener la imagen desde tus datos
            Bitmap imagen = ObtenerImagenDesdeDatos();

            // Guarda la imagen en el archivo temporal
            imagen.Save(rutaImagenTemporal, ImageFormat.Jpeg);
        }

        private static Bitmap ObtenerImagenDesdeDatos()
        {
            try
            {
                // El nombre del archivo de la imagen
                string nombreArchivoImagen = "logo_hospital_eloisa_torrent.jpg";

                // Combina el nombre del archivo con la ruta del directorio actual
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivoImagen);

                // Carga la imagen desde el archivo
                return new Bitmap(rutaCompleta);
            }
            catch (Exception ex)
            {
                // Manejar errores, como archivo no encontrado
                Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
                return new Bitmap(100, 100); // Devuelve una imagen en blanco en caso de error
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    object valorCelda = dataGridView1.Rows[e.RowIndex].Cells["Tipo"].Value;

                    // Llamar al método correspondiente según el valor de la celda
                    if (valorCelda != null)
                    {
                        if (valorCelda.Equals("Atencion"))
                        {
                            object valorIdObject = dataGridView1.Rows[e.RowIndex].Cells["id_atencion"].Value;

                            string valorId = valorIdObject.ToString();
                            _presenterAtencion.buscar(valorId);
                            _presenterOrden.buscarOrden(AtencionSingleton.Instance.AtencionAutenticada.IdOrden);
                            cargarOrdenDatos();

                        }
                        else if (valorCelda.Equals("Evaluacion"))
                        {
                            int valorId = (int)dataGridView1.Rows[e.RowIndex].Cells["id_evaluacion"].Value;
                            _presenterEvaluacion.BuscarPorId(valorId);
                            cargarEvaluacionDatos();

                        }
                        else if (valorCelda.Equals("Analisis"))
                        {
                            int valorId = (int)dataGridView1.Rows[e.RowIndex].Cells["id_analisis"].Value;
                            _presenterAnalisis.BuscaryRemplazar(valorId);
                            _presenterOrden.buscarOrden(AnalisisSingleton.Instance.AnalisisAutenticado.IdOrden);
                            cargarOrdenDatos();
                        }
                    }

                }
            }

        }
        private void cargarEvaluacionDatos()
        {
            evaluacionDatos pacienteControl = new evaluacionDatos();
            pacienteControl.Dock = DockStyle.Fill;

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                panelOpciones.Controls.Clear();


                panelOpciones.Controls.Add(pacienteControl);




            }
        }

        private void cargarOrdenDatos()
        {
            OrdenMedicoDatos pacienteControl = new OrdenMedicoDatos();
            pacienteControl.Dock = DockStyle.Fill;

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;



                panelOpciones.Controls.Clear();


                panelOpciones.Controls.Add(pacienteControl);




            }
        }

    }
}
