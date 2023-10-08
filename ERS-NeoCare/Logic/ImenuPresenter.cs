using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.view.ERS_NeoCare.View;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class ImenuPresenter
    {
        private IMenuView _view; 
        private UsuarioModel _usuario;
        private ProfesionService _profesionService;
        public ImenuPresenter(IMenuView view, UsuarioModel usuario,ProfesionService profesionService)
        {
            _view = view;
            _usuario = usuario;
            _profesionService = profesionService;


        }
        public void CargarProfesion()
        {
            int idProfesion = _usuario.ProfesionID;
            
            _view.MostrarDescripcionProfesion(_profesionService.ObtenerDescripcionProfesion(idProfesion));

        }
        public void cargarUserControl()
        {
            int idProfesion = _usuario.ProfesionID;
            switch (idProfesion)
            {
                case 5:
                    admin admin = new admin();
                    _view.AgregarUserControl(admin);
                    admin.adminUsuariosButtonClick+= adminUsuariosButtonClick;
                    admin.BajasAdminButtonClick+= BajasAdminButtonClick;
                    break;

                case 1:
                    Administrativo ad = new Administrativo();
                    ad.OpcionesButtonClick += Administrativo_OpcionesButtonClick;
                    ad.TurnoAdminButtonClick += AdmnistrativoTurnoAdminButtonClick;
                    _view.AgregarUserControl(ad);
                    break;
                case 2:
                    Enfermero en = new Enfermero();
                    en.enfermeroPacientesButtonClick += enfermeroPacientesButtonClick;
                    en.enfermeroAtencionButtonClick += enfermeroAtencionButtonClick;
                    _view.AgregarUserControl(en);
                    break;
                case 3:
                    medico m = new medico();
                    m.TurnoAdminButtonClick += TurnoMedButtonClick;
                    m.PacienteButtonClick += PacienteButtonClick;
                    m.ListaTurnosButtonClick += ListaTurnosMedicoClick;
                    _view.AgregarUserControl(m);
                    break;
                case 4:
                    Bioquimico b = new Bioquimico();
                    b.ListaAnalisisButtonClick+= ListaAnalisisButtonClick;
                    b.ListaPacienteButtonClick += ListaPacienteButtonClick;
                   
                    _view.AgregarUserControl(b);
                    break;
                default:
                    // Manejar caso por defecto si es necesario.
                    break;
            }
        }

        private void BajasAdminButtonClick(object sender, EventArgs e)
        {
            lista_usuarios lista = new lista_usuarios();
            _view.AgregarSubMenu(lista);
        }

        private void adminUsuariosButtonClick(object sender, EventArgs e)
        {
            lista_usuarios lista = new lista_usuarios();
            _view.AgregarSubMenu(lista);
        }

        private void enfermeroPacientesButtonClick(object sender, EventArgs e)
        {
           lista_paciente_enfermero lista = new lista_paciente_enfermero();
            _view.AgregarSubMenu(lista);
        }

        private void enfermeroAtencionButtonClick(object sender, EventArgs e)
        {
            lista_atenciones_enfermero lista = new lista_atenciones_enfermero();
            _view.AgregarSubMenu(lista);
        }

        private void ListaAnalisisButtonClick(object sender, EventArgs e)
        {
            lista_analisis_bioquimico lista = new lista_analisis_bioquimico();
            _view.AgregarSubMenu(lista);
        }
        private void ListaPacienteButtonClick(object sender, EventArgs e)
        {
            lista_paciente_bioquimico lista = new lista_paciente_bioquimico();
            _view.AgregarSubMenu(lista);
        }

        private void ListaTurnosMedicoClick(object sender, EventArgs e)
        {
            ListaDeTurnos turno = new ListaDeTurnos();
            _view.AgregarSubMenu(turno);
        }

        private void TurnoMedButtonClick(object sender, EventArgs e)

        {
            TurnosMedico turno = new TurnosMedico(null);
            _view.AgregarSubMenu(turno);
        }

        private void PacienteButtonClick(object sender, EventArgs e)
        {
            PacientesMedico pacientesMedico = new PacientesMedico();
            _view.AgregarSubMenu(pacientesMedico);
        }

        private void AdmnistrativoTurnoAdminButtonClick(object sender, EventArgs e)
        {
            turnoAdministrativo turno = new turnoAdministrativo(null);
           _view.AgregarSubMenu(turno);
        }

        private void Administrativo_OpcionesButtonClick(object sender, EventArgs e)
        {
            lista_paciente lista = new lista_paciente();
            _view.AgregarSubMenu(lista);
        }

        private void turnoPacienteCargar(object sender, Tuple<string> args)
        {
            string dni_paciente = args.Item1;
            turnoAdministrativo turno = new turnoAdministrativo(dni_paciente);
            _view.AgregarSubMenu(turno);
        }


    }
}
