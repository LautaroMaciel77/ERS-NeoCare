using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class turnoAdministrativo : UserControl
    {
        private DateTime select;
        private string rangoHora;
        private string dni;
        public turnoAdministrativo(string dni)
        {
            this.dni = dni;
            InitializeComponent();

            cargarHora();
        }

        private void cargarHora()
        {
            int intervaloEnMinutos = 30;
            int totalHoras = 24;
            int totalColumnas = (totalHoras * 60) / intervaloEnMinutos;
            label2.Text = "horario seleccionada: ";
            textboxDni.Text = dni;
            for (int i = 0; i < totalColumnas; i++)
            {


                // Agrega una columna al DataGridView con el encabezado correspondiente al intervalo de tiempo
                dataGridViewHora.Rows.Add();
                cargarFecha();

            }
        }

        private void cargarFecha()
        {

            // Establecer la hora de inicio y fin para los bloques de 30 minutos
            TimeSpan horaInicio = new TimeSpan(0, 0, 0); // 00:00
            TimeSpan horaFin = new TimeSpan(23, 59, 59); // 23:59:59

            // Calcular el número total de bloques de 30 minutos en un día
            int intervaloEnMinutos = 30;
            int totalBloques = (int)(horaFin.TotalMinutes / intervaloEnMinutos) + 1;

            // Crear una lista de bloques de horario
            List<string> bloquesDeHorario = new List<string>();

            // Generar los bloques de horario
            for (int i = 0; i < totalBloques; i++)
            {
                TimeSpan bloqueInicio = horaInicio.Add(TimeSpan.FromMinutes(i * intervaloEnMinutos));
                TimeSpan bloqueFin = horaInicio.Add(TimeSpan.FromMinutes((i + 1) * intervaloEnMinutos));

                // Agregar el bloque de horario a la lista
                bloquesDeHorario.Add($"{bloqueInicio:hh\\:mm} - {bloqueFin:hh\\:mm}");
            }

            // Limpiar las filas existentes en el DataGridViewHora
            dataGridViewHora.Rows.Clear();

            // Agregar la lista de bloques de horario a la primera columna del DataGridViewHora
            foreach (string bloque in bloquesDeHorario)
            {
                dataGridViewHora.Rows.Add(bloque);
            }

            // Obtener la fecha seleccionada del MonthCalendar

            // Actualizar la etiqueta de fecha seleccionada
            select = monthCalendar1.SelectionStart;
        }




        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            select = monthCalendar1.SelectionStart;
        }

        private void labelDni_Click(object sender, EventArgs e)
        {

        }

        private void textboxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void dataGridViewHora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewHora.Rows.Count > 0)
            {
                if (dataGridViewHora.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    rangoHora = dataGridViewHora.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = "horario seleccionada: " + rangoHora;
                }
            }

        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxDni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (select == null || rangoHora == null)
            {
                MessageBox.Show("Asegúrate de seleccionar una fecha y un rango de hora antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}


