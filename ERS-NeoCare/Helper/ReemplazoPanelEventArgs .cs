using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ERS_NeoCare.Helper
{
    public class ReemplazoPanelEventArgs : EventArgs
    {
        public UserControl Control { get; }
        public PacienteModel Paciente { get; }

        public ReemplazoPanelEventArgs(UserControl control, PacienteModel paciente)
        {
            Control = control;
            Paciente = paciente;
        }
    }
}
