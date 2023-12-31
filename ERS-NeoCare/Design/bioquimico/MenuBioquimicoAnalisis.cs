﻿using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class MenuBioquimicoAnalisis : UserControl
    {
        public event EventHandler closeclick;
        public event EventHandler crearClick;
        public event EventHandler verPacienteclick;
        public MenuBioquimicoAnalisis()
        {
            InitializeComponent();
        }

        private void menuPaciente_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            closeclick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            crearClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnVerPaciente_Click(object sender, EventArgs e)
        {
            verPacienteclick?.Invoke(this, EventArgs.Empty);

        }
    }
}
