using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ERS_NeoCare.Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButtonIniciar_Click(object sender, EventArgs e)
        {
            {
                // Establece la cadena de conexión a la base de datos.
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";


                // Crea la conexión a la base de datos.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                
                    // Crea el comando SQL con las columnas correctas.
                    using (SqlCommand command = new SqlCommand("SELECT dni , pass FROM personal_salud WHERE dni = @NombreUsuario AND pass = @Contraseña", connection))
                    {
                        // Asigna los valores de los parámetros (@NombreUsuario y @Contraseña).
                        command.Parameters.AddWithValue("@NombreUsuario", textBoxUser.Text);
                        command.Parameters.AddWithValue("@Contraseña", textBoxPass.Text);
                        object dni = command.ExecuteScalar();
                        // Ejecuta la consulta y verifica si se encuentra una coincidencia.
                        using (SqlDataReader reader = command.ExecuteReader())
                          
                        {
                            if (reader.Read())
                            {
                                textBoxUser.Text = string.Empty;
                                textBoxPass.Text = string.Empty;    
                                // Las credenciales son válidas, abre el formulario "Home".
                                string userDniStr = dni.ToString();

                                menu homeForm = new menu(userDniStr);
                                homeForm.Show();
                          
                            }
                            else
                            {
                                // Las credenciales no son válidas, muestra un mensaje de error.
                                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
                            }
                        }
                    }
                }
            }
        }

      
    }
}
