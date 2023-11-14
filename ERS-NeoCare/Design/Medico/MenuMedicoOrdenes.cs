using System;
using System.Windows.Forms;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Paciente;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;

namespace ERS_NeoCare.Design.Medico
{
    public partial class MenuMedicoOrdenes : UserControl
    {
        private menu MainForm { get; set; }

        public event EventHandler closeclick;
        public event EventHandler cambiarEstado;
        public MenuMedicoOrdenes()
        {


            InitializeComponent();
         

        }

        private void iconClose_Click(object sender, EventArgs e)
        {

        }

        //REMPLAZAR ESTO POR MANEJO EVENTO EN LA SEGUNDA PARTE DEL PROYECTO 
        private void iconTurno_Click(object sender, EventArgs e)
        {
            OrdenMedico tm = new OrdenMedico();
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
            PacienteView pacienteControl = new PacienteView();
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

        private void iconEvaluacion_Click(object sender, EventArgs e)
        {
            evaluacion pacienteControl = new evaluacion();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            EstadoOrden pacienteControl = new EstadoOrden();
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

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            cambiarEstado?.Invoke(this, EventArgs.Empty);
        }
    }
 }

