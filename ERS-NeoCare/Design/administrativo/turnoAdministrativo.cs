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
            _presenter = new TurnoPresenter(this, new TurnoService(Configuracion.ConnectionString));
            PacienteSingleton.Instance.Desautenticar();
            cargarHora();
            panelBuscar.Visible = false;
            comboBox1.SelectedIndex = 0;
            labelMedico.Text = " ";
            labelPaciente.Text = " ";
        }

        private void cargarHora()
        {
            int intervaloEnMinutos = 30;
            int totalHoras = 24;
            int totalColumnas = (totalHoras * 60) / intervaloEnMinutos;
            labelHora.Text = "";
            labelFecha.Text = "";
            if (PacienteSingleton.Instance.pacienteAutenticado != null)
            {
                labelPaciente.Text = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " "
                                + PacienteSingleton.Instance.pacienteAutenticado.Apellido;
            }
            else {
                labelPaciente.Text = "";
            }

            if (UsuarioBusqueda.Instance.UsuarioAutenticado != null)
            {
                labelMedico.Text = UsuarioBusqueda.Instance.UsuarioAutenticado.Nombre + " "
                               + UsuarioBusqueda.Instance.UsuarioAutenticado.Apellido;
            }
            else {
                labelMedico.Text = "";
            }

            

            for (int i = 0; i < totalColumnas; i++)
            {                
                dataGridViewHora.Rows.Add();
                cargarFecha();

            }
        }

        private void cargarFecha()
        {

           TimeSpan horaInicio = new TimeSpan(7, 0, 0); // 00:00:00
            TimeSpan horaFin = new TimeSpan(12, 0, 0); // 23:59:59

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
            CargarDatosEnDataGridView();
        }


        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            select = monthCalendar1.SelectionStart;
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;


            labelFecha.Text = fechaSeleccionada.ToString("dd/MM/yyyy");
            cargarFecha();
        }

        private void CargarDatosEnDataGridView()
        {
            // ista de turnos desde el presenter
            List<Turno> listaTurnos = _presenter.RecopilarTurnos();

            // Verifica si hay turnos para la fecha y el rangoHora seleccionados
            if (listaTurnos != null)
            {
                foreach (Turno turno in listaTurnos)
                {
                    // Verifica si la fecha y el rangoHora coinciden
                    if (turno.SelectedDate == select && turno.SelectedTimeRange != null)
                    {
                        string rangoHoraTurno = turno.SelectedTimeRange.Value.ToString("hh\\:mm");

                        // Encuentra la fila en el DataGridView que coincide con el rangoHora
                        foreach (DataGridViewRow row in dataGridViewHora.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().StartsWith(rangoHoraTurno))
                            {
                                if(UsuarioBusqueda.Instance.UsuarioAutenticado == null)
                                {

                                    break;
                                }
                                if (turno.Medico_Id == UsuarioBusqueda.Instance.UsuarioAutenticado.id)
                                {
                                    row.Cells[1].Value = "NO";
                                    break;
                                }
                           
                            }
                        }
                    }
                }
            }
        }


        private void dataGridViewHora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridViewHora.Rows.Count > 0)
            {
                if (dataGridViewHora.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    rangoHora = dataGridViewHora.Rows[e.RowIndex].Cells[0].Value.ToString();
                    labelHora.Text = rangoHora;
                    selectedRowIndex = e.RowIndex;
                }
            }

        }

        private void textboxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {

            if (UsuarioBusqueda.Instance.UsuarioAutenticado == null || PacienteSingleton.Instance.pacienteAutenticado == null)
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
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewHora.Rows.Count)
            {
                if (dataGridViewHora.Rows[selectedRowIndex].Cells[1].Value != null && dataGridViewHora.Rows[selectedRowIndex].Cells[1].Value.ToString() == "NO")
                {
                    MessageBox.Show("El turno seleccionado no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string[] partes = rangoHora.Split('-');

            TimeSpan horaInicio = TimeSpan.Parse(partes[0].Trim());
  
            Turno turno = new Turno
            {
                SelectedDate = select,
                SelectedTimeRange = horaInicio,
                Prioridad = prioridad,
                Estado=false,
                Medico_Id = UsuarioBusqueda.Instance.UsuarioAutenticado.id,
                Paciente_Id = PacienteSingleton.Instance.pacienteAutenticado.Id
            };

            _presenter.insertarTurno(turno);
            cargarFecha();
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


        private void AceptarClick(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
            if (UsuarioBusqueda.Instance.UsuarioAutenticado != null)
            {
                labelMedico.Text = UsuarioBusqueda.Instance.UsuarioAutenticado.Nombre + " " + UsuarioBusqueda.Instance.UsuarioAutenticado.Apellido;
            }
            if (PacienteSingleton.Instance.pacienteAutenticado != null)
            {
                labelPaciente.Text = PacienteSingleton.Instance.pacienteAutenticado.Nombre + " " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;
            }
            CargarDatosEnDataGridView();

        }



        private void Closeclick(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
            CargarDatosEnDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seleccion = comboBox1.SelectedItem.ToString();
            prioridad = seleccion;
        
        }

        internal void Insertar(bool v)
        {
            if (v)
            {
                MessageBox.Show("Turno generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error y no se pudo generar el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_buscar_medico_paciente_Click(object sender, EventArgs e)
        {
            panelBuscar.Visible = true;
            buscarPaciente buscarPaciente = new buscarPaciente();
            buscarPaciente.Dock = DockStyle.Fill;
            buscarPaciente.CloseClick += Closeclick;
            buscarPaciente.AceptarClick += AceptarClick;
   ;
            panelBuscar.Controls.Clear();
            panelBuscar.Controls.Add(buscarPaciente);
            buscarPaciente.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (UsuarioBusqueda.Instance.UsuarioAutenticado == null || PacienteSingleton.Instance.pacienteAutenticado == null)
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
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewHora.Rows.Count)
            {
                if (dataGridViewHora.Rows[selectedRowIndex].Cells[1].Value != null && dataGridViewHora.Rows[selectedRowIndex].Cells[1].Value.ToString() == "NO")
                {
                    MessageBox.Show("El turno seleccionado no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string[] partes = rangoHora.Split('-');

            TimeSpan horaInicio = TimeSpan.Parse(partes[0].Trim());

            Turno turno = new Turno
            {
                SelectedDate = select,
                SelectedTimeRange = horaInicio,
                Prioridad = prioridad,
                Estado = false,
                Medico_Id = UsuarioBusqueda.Instance.UsuarioAutenticado.id,
                Paciente_Id = PacienteSingleton.Instance.pacienteAutenticado.Id
            };

            _presenter.insertarTurno(turno);
            LimpiarCampos();
            cargarFecha();
        }
        private void LimpiarCampos()
        {
           labelMedico.Text = " ";
            labelPaciente.Text = " ";
            labelHora.Text = " ";   
            labelFecha.Text = " ";
            UsuarioBusqueda.Instance.DesautenticarUsuario();
           PacienteSingleton.Instance.Desautenticar();
            rangoHora = null; 
            selectedRowIndex = 0;
            select = monthCalendar1.SelectionStart;

            comboBox1.SelectedIndex = 0; 

        }
    }
}


