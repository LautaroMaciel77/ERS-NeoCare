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
        internal bool insertar(Turno turnoModel)
        {
        
                {
                    try
                    {
                        var context = DbContextManager.GetContext();

                        var turno = new Turno
                        {
             
                SelectedDate = turnoModel.SelectedDate ,
                SelectedTimeRange = turnoModel.SelectedTimeRange,
                Prioridad = turnoModel.Prioridad,
                Medico_Id = turnoModel.Medico_Id ,
                Paciente_Id = turnoModel .Paciente_Id ,
            };
                

                        // Agrega el nuevo usuario al contexto
                        context.turnos.Add(turno);

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
            }

        internal List<Turno> ObtenerDatos()
        {

            var context = DbContextManager.GetContext();

            var turnos = context.turnos.ToList();
            return turnos;
        }
    }
}
