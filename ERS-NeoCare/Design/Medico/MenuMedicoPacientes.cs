using System;
using System.Windows.Forms;
using ERS_NeoCare.Design.Paciente;
using ERS_NeoCare.Model;

namespace ERS_NeoCare.Design.Medico
{
    public partial class MenuMedicoPacientes : UserControl
    {
        private menu MainForm { get; set; }
        private PacienteService paciente;
        public event EventHandler closeclick;
        public MenuMedicoPacientes(PacienteService paciente)
        {
            this.paciente = paciente;

            InitializeComponent();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {

        }

        //REMPLAZAR ESTO POR MANEJO EVENTO EN LA SEGUNDA PARTE DEL PROYECTO 
        private void iconTurno_Click(object sender, EventArgs e)
        {
            TurnosMedico tm = new TurnosMedico(paciente);
            tm.Dock = DockStyle.Fill; 

            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;
                panelOpciones.Controls.Clear();
                panelOpciones.Controls.Add(tm);
            }
        }


        //REMPLAZAR ESTO POR MANEJO EVENTO EN LA SEGUNDA PARTE DEL PROYECTO 
        private void iconVer_Click(object sender, EventArgs e)
        {
            PacienteView pacienteControl = new PacienteView(paciente);
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

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            closeclick?.Invoke(this, EventArgs.Empty);
        }
    }
 }

