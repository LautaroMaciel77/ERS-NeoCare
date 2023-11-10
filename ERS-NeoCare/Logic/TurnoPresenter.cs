using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class TurnoPresenter
    {

        public TurnoService _service;
        private PacientesMedico _viewMedico;
        public turnoAdministrativo _viewAdministrativo;
        public ListaTurnosAdministrativo _viewlista;
        private ListaDeTurnos _viewListaTurnoMedico;
      

        public TurnoPresenter(turnoAdministrativo view, TurnoService service)
        {
            _service = service;
            _viewAdministrativo = view;
        }
        public TurnoPresenter(PacientesMedico view, TurnoService service)
        {
            _service = service;
            _viewMedico = view;
        }

        public TurnoPresenter(ListaTurnosAdministrativo view, TurnoService service)
        {
            _service = service;
            _viewlista = view;
        }
        public TurnoPresenter(TurnoService service)
        {
            _service = service;

        }

        public TurnoPresenter(ListaDeTurnos listaDeTurnos, TurnoService service)
        {
            _viewListaTurnoMedico = listaDeTurnos;
           _service = service;
        }

        public void insertarTurno(Turno turnoModel)
        {
            _viewAdministrativo.Insertar(_service.insertar(turnoModel));


        }
        public void CargarPacientePorTurno()
        {
            List<Turno> listaTurnos = _service.ObtenerDatos();
            List<PacienteModel> listaPacientes = listaTurnos.Select(t => t.Paciente).ToList();
            DataTable data = ConvertidorListDatatable.ConvertirListaPaciente(listaPacientes);
            _viewMedico.MostrarDatosPaciente(data);
        }
        public void CargarPacienteMedico()
        {
            List<Turno> listaTurnos = _service.ObtenerDatos();
            int a = UsuarioSingleton.Instance.UsuarioAutenticado.id;
            List<Turno> turnosMedico = listaTurnos.Where(t => t.Medico_Id == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();
            List<PacienteModel> listaPacientes = turnosMedico.Select(t => t.Paciente).ToList();
            DataTable data = ConvertidorListDatatable.ConvertirListaPaciente(listaPacientes);
            _viewMedico.MostrarDatosPaciente(data);
        }
        public void BuscarPacienteMedico(string searchText)
        {
            List<Turno> listGeneral = _service.ObtenerDatos();
             List<Turno> listaTurnos = listGeneral.Where(t => t.Medico.DNI == UsuarioSingleton.Instance.UsuarioAutenticado.DNI).ToList();
            List<PacienteModel> listaPacientes = listaTurnos.Select(t => t.Paciente).ToList();
            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI
                listaPacientes = listaPacientes.Where(p => p.Dni == dni).ToList();
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                listaPacientes = listaPacientes.Where(p =>
                    p.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Nombre + " " + p.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }


            DataTable data = ConvertidorListDatatable.ConvertirListaPaciente(listaPacientes);
            _viewMedico.MostrarDatosPaciente(data);
        }
        public void BuscarTurnoListaTurnoMedico(string searchText)
        {

            _viewListaTurnoMedico.cargarDatosPaciente(BuscarTurno(searchText));

        }
        public List<Turno> BuscarTurno(string searchText)
        {
            List<Turno> listGeneral = _service.ObtenerDatos();
           
            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI en turnos
                listGeneral.Where(t => t.Paciente.Dni == dni).ToList();

            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo en turnos
                listGeneral.Where(t =>
                   t.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   t.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   (t.Paciente.Nombre + " " + t.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            }
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(listGeneral);
            return listGeneral;
        }
        public List<Turno> RecopilarTurnos()
        {
            return _service.ObtenerDatos();
        }
        public void ListaTurnos()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            _viewlista.cargarDatos(data);
        }
        public void ListaTurnoMedicos()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            _viewListaTurnoMedico.cargarDatosPaciente(_service.ObtenerDatos());
        }

        public DataTable ListaTurnosGeneral()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            return data;
        }

        internal void ObtenerTurnoEstado(string v)
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerTurnoEstado(v));
            _viewlista.cargarDatos(data);
        }

        internal void cambiarEstado(int id)
        {
            _service.CambiarEstado(id);
            _viewMedico.mensaje("estado cambiado");
        }
        internal void CargarFiltro(string v)
        {
           
            DataTable data = ConvertidorListDatatable.ConvertirListaPaciente(_service.ObtenerPacientesPorEstado(v));

            _viewMedico.MostrarDatosPaciente(data);
        }

    }
}
