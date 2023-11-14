﻿using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class medico : UserControl
    {
        private menu MainForm { get; set; }
        

        public event EventHandler PacienteButtonClick;
        public event EventHandler TurnoAdminButtonClick;
        public event EventHandler EvaluacionesButtonClick;

        public medico()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PacienteButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TurnoAdminButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            EvaluacionesButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            EvaluacionesButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
