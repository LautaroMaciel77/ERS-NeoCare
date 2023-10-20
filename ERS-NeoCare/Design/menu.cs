using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.view.ERS_NeoCare.View;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class menu : Form, IMenuView
    {

        private string userDni;
        private int profesionId;
        private SqlConnection connection;
        private ImenuPresenter _presenter; // Agrega un campo para el presentador

        public menu( )
        {
            InitializeComponent();

            
            _presenter = new ImenuPresenter(this, new ProfesionService(Configuracion.ConnectionString));           
            _presenter.CargarProfesion();
            _presenter.cargarUserControl();
            
        
        }



            public void MostrarDescripcionProfesion(string descripcion)
        {
            
            labelProfesion.Text = descripcion;
        }

        


        public void AgregarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelSubMenu.Controls.Clear();
            panelSubMenu.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void AgregarSubMenu(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelOpciones.Controls.Clear();
            panelOpciones.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}