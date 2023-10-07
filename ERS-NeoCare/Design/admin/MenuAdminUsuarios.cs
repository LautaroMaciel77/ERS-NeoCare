﻿using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;
namespace ERS_NeoCare.Design.Medico
{
    public partial class MenuAdminUsuarios : UserControl
    {
        private menu MainForm { get; set; }
        private string userDni;
        private PacienteService paciente;
        public event EventHandler closeclick;
        public MenuAdminUsuarios( )
        {
            ;

            InitializeComponent();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {

        }

        private void iconTurno_Click(object sender, EventArgs e)
        {
            TurnosMedico tm = new TurnosMedico(paciente);
            tm.Dock = DockStyle.Fill; // Ajusta el control al tamaño del panelOpciones

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
 
           
            }
        }

        private void iconVer_Click(object sender, EventArgs e)
        {
            PacienteView pacienteControl = new PacienteView(paciente);
            pacienteControl.Dock = DockStyle.Fill; // Ajusta el control al tamaño del panelOpciones

            // Accede al formulario 'menu' desde el control actual
            menu menuForm = this.ParentForm as menu;

            if (menuForm != null)
            {
            
           
            }

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            closeclick?.Invoke(this, EventArgs.Empty);
        }
    }
}
