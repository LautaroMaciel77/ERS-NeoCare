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
        private int selectedRowIndex = -1;
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
                dataGridViewHora.Rows.Add();
                cargarFecha();

            }
        }

        private void cargarFecha()
        {

           TimeSpan horaInicio = new TimeSpan(0, 0, 0); // 00:00
            TimeSpan horaFin = new TimeSpan(23, 59, 59); // 23:59:59

            int intervaloEnMinutos = 30;
            int totalBloques = (int)(horaFin.TotalMinutes / intervaloEnMinutos) + 1;

            List<string> bloquesDeHorario = new List<string>();
                     
            for (int i = 0; i < totalBloques; i++)
            {
                TimeSpan bloqueInicio = horaInicio.Add(TimeSpan.FromMinutes(i * intervaloEnMinutos));
                TimeSpan bloqueFin = horaInicio.Add(TimeSpan.FromMinutes((i + 1) * intervaloEnMinutos));

        
                bloquesDeHorario.Add($"{bloqueInicio:hh\\:mm} - {bloqueFin:hh\\:mm}");
            }
                   
            dataGridViewHora.Rows.Clear();
                      
            foreach (string bloque in bloquesDeHorario)
            {
                dataGridViewHora.Rows.Add(bloque);
            }
                   
            select = monthCalendar1.SelectionStart;
        }


        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            select = monthCalendar1.SelectionStart;
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;

 
            label1.Text = fechaSeleccionada.ToString("dd/MM/yyyy");
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
                    selectedRowIndex = e.RowIndex;
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
            if (string.IsNullOrWhiteSpace(textBoxMatricula.Text))
            {
                MessageBox.Show("El campo matricula no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (select == null || rangoHora == null)
            {
                MessageBox.Show("Asegúrate de seleccionar una fecha y un rango de hora antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (select < DateTime.Now)
            {
                MessageBox.Show("Asegúrate de seleccionar una fecha correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            dataGridViewHora.Rows[selectedRowIndex].Cells[1].Value = "NO";
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}


