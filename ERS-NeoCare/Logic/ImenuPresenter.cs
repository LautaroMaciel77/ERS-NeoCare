﻿using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Medico;
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
        private UsuarioService _usuarioService;
        public ImenuPresenter(IMenuView view,ProfesionService profesionService)
        {
            _view = view;
        
            _profesionService = profesionService;


        }
        public void CargarProfesion()
        {
            _view.MostrarDescripcionProfesion(_profesionService.ObtenerDescripcionProfesion());

        }

        public void cargarUserControl()
        {
           
            

            switch (UsuarioSingleton.Instance.UsuarioAutenticado.ProfesionID)

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
                    ad.ReporteAdminButtonClick += ReporteAdminButtonClick;
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
                    m.OrdenesAdminButtonClick += OrdenoMedButtonClick;
                    m.PacientesAtendidosClick += M_PacientesAtendidosClick;
                    m.PacienteButtonClick += PacienteButtonClick;
                    m.EvaluacionesButtonClick += EvaluacionesButtonClick;
                    _view.AgregarUserControl(m);
                    break;
                case 4:
                    Bioquimico b = new Bioquimico();
                    b.ListaAnalisisButtonClick+= ListaAnalisisButtonClick;
                    b.ListaAnalisisHechoClick += ListaAnalisisHechoClick;
                   
                    _view.AgregarUserControl(b);
                    break;
                default:
                    // Manejar caso por defecto si es necesario.
                    break;
            }
        }

        private void M_PacientesAtendidosClick(object sender, EventArgs e)
        {
            ListaDeTurnos lista = new ListaDeTurnos();
            _view.AgregarSubMenu(lista);
        }

        private void ListaAnalisisHechoClick(object sender, EventArgs e)
        {
            lista_analisis_bioquimico lista = new lista_analisis_bioquimico();
            _view.AgregarSubMenu(lista);
        }

        private void ReporteAdminButtonClick(object sender, EventArgs e)
        {
            ListaTurnosAdministrativo lista = new ListaTurnosAdministrativo();
            _view.AgregarSubMenu(lista);
        }

        private void BajasAdminButtonClick(object sender, EventArgs e)
        {
            lista_baja_usuarios lista = new lista_baja_usuarios();
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
            lista_paciente_bioquimico lista = new lista_paciente_bioquimico();
            _view.AgregarSubMenu(lista);
        }
        private void ListaPacienteButtonClick(object sender, EventArgs e)
        {
            lista_paciente_bioquimico lista = new lista_paciente_bioquimico();
            _view.AgregarSubMenu(lista);
        }

        private void EvaluacionesButtonClick(object sender, EventArgs e)
        {
            Evaluaciones turno = new Evaluaciones();
            _view.AgregarSubMenu(turno);
        }

        private void OrdenoMedButtonClick(object sender, EventArgs e)

        {
            EstadoOrden turno = new EstadoOrden();
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
