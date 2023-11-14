using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Model
{
    internal class HistorialService
    {
        internal bool Insertar(HistorialModel historial)
        {
            try
            {
                var context = DbContextManager.GetContext();

                if (context == null)
                {
                    // Asegúrate de que el contexto no sea nulo
                    Console.WriteLine("Error: Contexto de base de datos nulo.");
                    MessageBox.Show("Error: Contexto de base de datos nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Agregar el historial al contexto
                context.historial.Add(historial);

                // Guardar los cambios en la base de datos
                int rowsAffected = context.SaveChanges();

                if (rowsAffected > 0)
                {
                    return true; // La inserción fue exitosa
                }
                else
                {
                    // Puedes manejar de manera diferente si no se afectaron filas
                    Console.WriteLine("Error: No se afectaron filas en la base de datos.");
                    MessageBox.Show("Error: No se afectaron filas en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales aquí.
                Console.WriteLine("Error al insertar historial: " + ex.Message);
                MessageBox.Show("Error al insertar historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // O manejar de otra manera apropiada
            }
        }

        internal List<HistorialModel> ObtenerHistorial()
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Consultar la tabla de historial y traer todos los registros
                List<HistorialModel> historiales = context.historial.ToList();

                // Cargar explícitamente las propiedades relacionadas para cada elemento en la lista
                foreach (var historial in historiales)
                {
                    if (historial.AtencionEnfermeria != null)
                        context.Entry(historial).Reference(h => h.AtencionEnfermeria).Load();

                    if (historial.Paciente != null)
                        context.Entry(historial).Reference(h => h.Paciente).Load();

                    if (historial.Medico != null)
                        context.Entry(historial).Reference(h => h.Medico).Load();

                    if (historial.Evaluacion != null)
                        context.Entry(historial).Reference(h => h.Evaluacion).Load();

                    if (historial.Analisis != null)
                        context.Entry(historial).Reference(h => h.Analisis).Load();
                }

                return historiales;
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