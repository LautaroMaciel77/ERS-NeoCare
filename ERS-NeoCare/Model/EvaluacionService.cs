using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ERS_NeoCare.Model
{
    internal class EvaluacionService
    {
        internal bool insertar(EvaluacionModel evaluacionModel)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Agregar el paciente al contexto
                context.evaluacion.Add(evaluacionModel);

                // Guardar los cambios en la base de datos
                int rowsAffected = context.SaveChanges();
                EvaluacionSingleton.Instance.Autenticar(evaluacionModel);
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }
        internal EvaluacionModel BuscarPorId(int id)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Buscar la evaluación por ID
                EvaluacionModel evaluacionEncontrada = context.evaluacion.Find(id);

                if (evaluacionEncontrada != null)
                {
                    // Almacenar la evaluación encontrada en EvaluacionSingleton
                    EvaluacionSingleton.Instance.Autenticar(evaluacionEncontrada);
                }
                else
                {
                    Console.WriteLine("No se encontró ninguna evaluación con el ID: " + id);
                }

                return evaluacionEncontrada;
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return null; // O manejar de otra manera apropiada
            }
        }
    }
}


