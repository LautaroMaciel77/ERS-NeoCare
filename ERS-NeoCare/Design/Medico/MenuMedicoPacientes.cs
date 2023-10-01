using System;
using System.Windows.Forms;
using ERS_NeoCare.Design.Paciente;
namespace ERS_NeoCare.Design.Medico
{
    public partial class MenuMedicoPacientes : UserControl
    {
        private menu MainForm { get; set; }
        private string userDni;

        public MenuMedicoPacientes(string dni)
        {
            this.userDni = dni;

            InitializeComponent();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {

        }

        private void iconTurno_Click(object sender, EventArgs e)
        {
            TurnosMedico tm = new TurnosMedico(userDni);
            tm.Dock = DockStyle.Fill; // Ajusta el control al tamaño del panelOpciones

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                // Llama al método para agregar el control al panelOpciones

            }
        }

        private void iconVer_Click(object sender, EventArgs e)
        {
            PacienteView pacienteControl = new PacienteView(userDni);
            pacienteControl.Dock = DockStyle.Fill; // Ajusta el control al tamaño del panelOpciones

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                Panel panelOpciones = menuForm.Controls["panelOpciones"] as Panel;


                // Borra cualquier control existente en el panelOpciones
                panelOpciones.Controls.Clear();

                // Agrega el control PacienteView al panelOpciones
                panelOpciones.Controls.Add(pacienteControl);
                // Llama al método para agregar el control al panelOpciones



            }
        }
    }
 }

