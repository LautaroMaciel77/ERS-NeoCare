using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Model
{
    internal class TipoAnalisisService
    {

        public bool DescripcionTipoAnalisisExistente(string descripcion)
        {
            try
            {
                var context = DbContextManager.GetContext();
                
          
                    return context.TipoAnalis.Any(t => t.descripcion == descripcion);
                
            }
            catch (Exception ex)
            {
             
                MessageBox.Show("Error al verificar descripción del tipo de análisis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        public bool InsertarTipoAnalisis(TipoAnalisModel tipoAnalisis)
        {
            try
            {
                
                if (DescripcionTipoAnalisisExistente(tipoAnalisis.descripcion))
                {
                    MessageBox.Show("Error: La descripción del tipo de análisis ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var context = DbContextManager.GetContext();
               
                    
                    context.TipoAnalis.Add(tipoAnalisis);

          
                    context.SaveChanges();

                    MessageBox.Show("Exito al crear análisis", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al insertar tipo de análisis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }
        public List<TipoAnalisModel> ObtenerTiposAnalisis()
        {
            try
            {
                var context = DbContextManager.GetContext();

                return context.TipoAnalis.ToList();
                
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Error al obtener tipos de análisis: " + ex.Message);
                return null; 
            }
        }
    }
}
