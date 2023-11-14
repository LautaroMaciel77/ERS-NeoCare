using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class bd : UserControl
    {
        public bd()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {


                string rutaCopiaSeguridad = saveFileDialog.FileName;
                RealizarBackup();

            }
        }
        private void RealizarBackup()
        {
            try
            {
                string databaseName = "DBNeoCare";
                string backupFolder = Path.Combine(Application.StartupPath, "Recursos", "CopiasSeguridad"); // Ruta de la carpeta de copias de seguridad en el proyecto
                string backupFileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak"; // Nombre del archivo con la fecha

                string rutaCopiaSeguridad = Path.Combine(backupFolder, backupFileName);

                // Verificar si la carpeta de copias de seguridad existe, y crearla si no
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                //string connectionString = "Data Source=DESKTOP-2JKMBB0\\SQLEXPRESS;Initial Catalog=DBNeoCare;Integrated Security=True";
                string connectionString = "Data Source=FARONOTE\\SQLEXPRESS_INST1;Initial Catalog=DBNeoCare;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string backupQuery = $"BACKUP DATABASE {databaseName} TO DISK = '{rutaCopiaSeguridad}'";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Copia de seguridad creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agregamos configuración de permisos para la carpeta de copia de seguridad
                        FileInfo fileInfo = new FileInfo(rutaCopiaSeguridad);
                        FileSecurity fileSecurity = fileInfo.GetAccessControl();
                        fileSecurity.AddAccessRule(new FileSystemAccessRule("NT SERVICE\\TuServicio", FileSystemRights.FullControl, AccessControlType.Allow));
                        fileInfo.SetAccessControl(fileSecurity);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la copia de seguridad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string backupFolder = Path.Combine(Application.StartupPath, "Recursos", "CopiasSeguridad");

                // Establecer la carpeta inicial para el diálogo de selección de archivos
                openFileDialog.InitialDirectory = backupFolder;

                openFileDialog.Filter = "Archivos de copia de seguridad (*.bak)|*.bak";
                openFileDialog.Title = "Seleccionar archivo de copia de seguridad";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaCopiaSeguridad = openFileDialog.FileName;

                    // Verificar si el archivo de copia de seguridad existe
                    if (File.Exists(rutaCopiaSeguridad))
                    {
                        RestaurarBackup(rutaCopiaSeguridad);
                    }
                    else
                    {
                        MessageBox.Show("El archivo de copia de seguridad no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
          
        }


        private void RestaurarBackup(string rutaCopiaSeguridad)
        {
            try
            {
                string databaseName = "DBNeoCare";

                //string connectionString = "Data Source=DESKTOP-2JKMBB0\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                string connectionString = "Data Source=FARONOTE\\SQLEXPRESS_INST1;Initial Catalog=master;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Detenemos todas las conexiones a la base de datos
                    string disableConnectionsQuery = $"ALTER DATABASE {databaseName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    using (SqlCommand disableConnectionsCommand = new SqlCommand(disableConnectionsQuery, connection))
                    {
                        disableConnectionsCommand.ExecuteNonQuery();
                    }

                    // Restauramos la base de datos desde el archivo de copia de seguridad
                    string restoreQuery = $"RESTORE DATABASE {databaseName} FROM DISK = '{rutaCopiaSeguridad}' WITH REPLACE";
                    using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
                    {
                        restoreCommand.ExecuteNonQuery();
                    }

                    // Volvemos a permitir conexiones a la base de datos
                    string enableConnectionsQuery = $"ALTER DATABASE {databaseName} SET MULTI_USER";
                    using (SqlCommand enableConnectionsCommand = new SqlCommand(enableConnectionsQuery, connection))
                    {
                        enableConnectionsCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Restauración de la base de datos completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButtonCrearCopia_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Esta acción creara una copia de seguridad de la base de datos actual. ¿Está seguro?",
                                             "Confirmar Copia de Seguridad",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    string rutaCopiaSeguridad = saveFileDialog.FileName;
                    RealizarBackup();
                }
            }
        }

        private void iconButtonRestaurar_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show("Esta acción le permitirá seleccionar una copia de seguridad que sobrescribirá la base de datos actual. ¿Está seguro?",
                                                      "Advertencia de Restauración",
                                                      MessageBoxButtons.OKCancel,
                                                      MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    string backupFolder = Path.Combine(Application.StartupPath, "Recursos", "CopiasSeguridad");

                    openFileDialog.InitialDirectory = backupFolder;

                    openFileDialog.Filter = "Archivos de copia de seguridad (*.bak)|*.bak";
                    openFileDialog.Title = "Seleccionar archivo de copia de seguridad";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaCopiaSeguridad = openFileDialog.FileName;

                        if (File.Exists(rutaCopiaSeguridad))
                        {
                            RestaurarBackup(rutaCopiaSeguridad);
                        }
                        else
                        {
                            MessageBox.Show("El archivo de copia de seguridad no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
