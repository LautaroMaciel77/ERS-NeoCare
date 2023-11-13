using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class HistorialService
    {
        internal bool Insertar(HistorialModel historial)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Agregar el historial al contexto
                context.historial.Add(historial);

                // Guardar los cambios en la base de datos
                int rowsAffected = context.SaveChanges();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales aquí.
                Console.WriteLine("Error al insertar historial: " + ex.Message);
                return false; // O manejar de otra manera apropiada
            }
        }

        internal List<HistorialModel> ObtenerHistorial()
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Consultar la tabla de historial y traer todos los registros
                List<HistorialModel> historial = context.historial.ToList();

                foreach (var historialItem in historial)
                {
                    // Cargar las propiedades de navegación según sea necesario
                    context.Entry(historialItem).Reference(h => h.Turno).Load();
                    context.Entry(historialItem).Reference(h => h.Analisis).Load();
                    context.Entry(historialItem).Reference(h => h.AtencionEnfermeria).Load();
                    context.Entry(historialItem).Reference(h => h.Medico).Load();
                    context.Entry(historialItem).Reference(h => h.Paciente).Load();
                    // Cargar otras propiedades de navegación si es necesario
                }

                return historial;
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales aquí.
                Console.WriteLine("Error al obtener historial: " + ex.Message);
                return null; // O manejar de otra manera apropiada, como lanzar una excepción
            }
        }
    }
}