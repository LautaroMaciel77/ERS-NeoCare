using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Design.view
{
    // IMenuView.cs
    using System;
    using System.Windows.Forms;

    namespace ERS_NeoCare.View
    {
        public interface IMenuView
        {
    
          //  event EventHandler OpcionesButtonClick;
            //event EventHandler TurnoAdminButtonClick;
           // event EventHandler PacienteButtonClick;
            void AgregarUserControl(UserControl userControl);
            void MostrarDescripcionProfesion(string profesion);
            void AgregarSubMenu(UserControl userControl);
            //void CargarUserControl(UserControl userControl, Panel panel);
        }
    }
}
