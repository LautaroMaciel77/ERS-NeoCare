using ERS_NeoCare.Design.administrativo;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class Administrativo : UserControl
    {
        private menu MainForm { get; set; }

        // Declara un evento personalizado para notificar clics en los botones
        public event EventHandler OpcionesButtonClick;
        public event EventHandler TurnoAdminButtonClick;
        public event EventHandler ReporteAdminButtonClick;
        public Administrativo()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            OpcionesButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TurnoAdminButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ReporteAdminButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Reporte pacienteControl = new Reporte();
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
    }
}

