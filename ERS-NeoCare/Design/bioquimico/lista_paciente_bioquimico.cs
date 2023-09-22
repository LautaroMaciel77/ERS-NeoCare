﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_paciente_bioquimico : UserControl
    {
        // Establece la cadena de conexión a la base de datos.

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private string userDni;
        //handler para cargar paciente
        public event EventHandler<Tuple<string>> historiaPacienteClick;

        private menu MainForm { get; set; }
        // Declara un evento personalizado para notificar clics en los botones

        public lista_paciente_bioquimico()
        {
    
            InitializeComponent();
            CargarDatosPaciente();
            //panelMenuPaciente.Visible = false;
        }

        private void CargarDatosPaciente()
        {
            // Crea una conexión a la base de datos.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define una consulta SQL para seleccionar todos los registros de la tabla paciente.
                    string query = "SELECT * FROM paciente";

                    // Crea un adaptador de datos y un DataSet para almacenar los resultados.
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Llena el DataSet con los datos de la consulta.
                    adapter.Fill(dataSet, "Paciente");

                    // Asigna el DataSet como origen de datos para el DataGridView.
                    DGVAdministrativo.DataSource = dataSet.Tables["Paciente"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de la tabla paciente: " + ex.Message);
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //panelMenuPaciente.Visible = false;
            //panelAgregarPaciente.Visible = true;


        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVAdministrativo.Columns["acciones"].Index)
            {
                // Obtén el valor de la celda "dni" de la fila en la que se hizo clic
                this.userDni = DGVAdministrativo.Rows[e.RowIndex].Cells["dni"].Value.ToString();

                // Muestra el valor del dni (puedes hacer lo que desees con él)
                // Muestra el panel de opciones
                //panelAgregarPaciente.Visible = false;
                //panelMenuPaciente.Visible = true;

            }
        }

  
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            //panelMenuPaciente.Visible = false;
        }

    
        private void iconButton3_Click(object sender, EventArgs e)
        {
            historiaPacienteClick?.Invoke(this, Tuple.Create(userDni));
        }
    }
}