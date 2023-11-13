using ERS_NeoCare.Design.administrativo;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class admin : UserControl
    {
        private menu MainForm { get; set; }

      
        public event EventHandler adminUsuariosButtonClick;
        public event EventHandler BajasAdminButtonClick;

        public admin()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            adminUsuariosButtonClick?.Invoke(this, EventArgs.Empty);
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            {
                BajasAdminButtonClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bd pacienteControl = new bd();
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

