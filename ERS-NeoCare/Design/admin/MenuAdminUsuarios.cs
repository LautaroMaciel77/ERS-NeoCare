using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.Medico
{
    public partial class MenuAdminUsuarios : UserControl
    {
        private menu MainForm { get; set; }
        private string userDni;

        public MenuAdminUsuarios(string dni)
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
                menuForm.addUserControl(tm, menuForm.panelOpciones);
            }
        }

        private void iconVer_Click(object sender, EventArgs e)
        {
            paciente pacienteControl = new paciente(userDni);
            pacienteControl.Dock = DockStyle.Fill; // Ajusta el control al tamaño del panelOpciones

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
                // Llama al método para agregar el control al panelOpciones
                menuForm.addUserControl(pacienteControl, menuForm.panelOpciones);
            }

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {

        }
    }
}
