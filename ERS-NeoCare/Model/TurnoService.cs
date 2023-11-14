using ERS_NeoCare.dbconexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class TurnoService
    {

        
        private string _connectionString;

        public TurnoService(string connectionString)
        {
            _connectionString = connectionString;
        }
        internal bool Insertar(Turno turnoModel)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Crea una nueva instancia de Turno y configura sus propiedades
                var nuevoTurno = new Turno
                {
                    SelectedDate = turnoModel.SelectedDate,
                    SelectedTimeRange = turnoModel.SelectedTimeRange,
                    Prioridad = turnoModel.Prioridad,
                    Estado = turnoModel.Estado,
                    Medico_Id = turnoModel.Medico_Id,
                    Paciente_Id = turnoModel.Paciente_Id,
                };

                // Agrega el nuevo turno al contexto
                context.turnos.Add(nuevoTurno);

                // Guarda los cambios en la base de datos
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                // Maneja excepciones aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }

        public List<Turno> ObtenerDatos()
        {

            var context = DbContextManager.GetContext();

            var turnos = context.turnos.ToList();
            return turnos;
        }

        public List<Turno> ObtenerTurnoEstado(bool v)
        {
            var context = DbContextManager.GetContext();

          
            var turnos = context.turnos
                .Where(t => t.Estado == v)
                .ToList();
      
            return turnos;
        }

        internal void CambiarEstado(int turnoId)
        {
          var context = DbContextManager.GetContext();

            var turno = context.turnos.SingleOrDefault(t => t.Id == turnoId);

                if (turno != null)
                {
                    // Cambiar el estado de "s" a "n" o de "n" a "s"
                  turno.Estado = !turno.Estado;

                    context.SaveChanges();
                }
            
        }
        public List<PacienteModel> ObtenerPacientesPorEstado(bool estado)
        {
            var context = DbContextManager.GetContext();

            var pacientes = context.turnos
                .Where(t => t.Estado == estado)
                .Select(t => t.Paciente)
                .Distinct()
                .ToList();

            return pacientes;
        }
    }
}
