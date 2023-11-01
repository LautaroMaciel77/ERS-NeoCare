﻿using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
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
        private string prioridad;
        private TurnoPresenter _presenter;
        public turnoAdministrativo(string dni)
        {
            this.dni = dni;
            InitializeComponent();
            _presenter = new TurnoPresenter(new TurnoService(Configuracion.ConnectionString));
            PacienteSingleton.Instance.Desautenticar();
            cargarHora();
            panelBuscar.Visible = false;
        }

        private void cargarHora()
        {
            int intervaloEnMinutos = 30;
            int totalHoras = 24;
            int totalColumnas = (totalHoras * 60) / intervaloEnMinutos;
            label2.Text = "horario seleccionada: ";
         
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

            if (UsuarioSingleton.Instance.UsuarioAutenticado == null || PacienteSingleton.Instance.pacienteAutenticado == null)
            {
                MessageBox.Show("Asegúrate de seleccionar un medico y un paciente antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (prioridad == null)
            {
                MessageBox.Show("Asegúrate de seleccionar una prioridad de turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Turno turno = new Turno
            {
                SelectedDate = select,
                SelectedTimeRange = TimeSpan.Parse(rangoHora),
                Prioridad = prioridad,
                Medico_Id = UsuarioSingleton.Instance.UsuarioAutenticado.id,
                Paciente_Id = PacienteSingleton.Instance.pacienteAutenticado.Id
            };

            _presenter.insertarTurno(turno);    
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

        private void btn_buscarMedico_Click(object sender, EventArgs e)
        {
            panelBuscar.Visible = true;
            buscarPaciente buscarPaciente = new buscarPaciente();
            buscarPaciente.Dock = DockStyle.Fill;
            buscarPaciente.CloseClick += Closeclick;

            panelBuscar.Controls.Clear();
            panelBuscar.Controls.Add(buscarPaciente);
            buscarPaciente.BringToFront();
        }

        private void Closeclick(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seleccion = comboBox1.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Alta":
                    prioridad = seleccion;
                    break;
                case "Normal":
                    prioridad = seleccion;
                    break;
                case "Baja":
                    prioridad = seleccion;
                    break;
                default:
                    prioridad = null;
                    break;
            }
        }

        internal void Insertar(bool v)
        {
            if (v)
            {
                MessageBox.Show("Turno insertado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Turno insertado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}


