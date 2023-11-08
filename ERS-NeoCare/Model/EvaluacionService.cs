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

                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }
    }
}
