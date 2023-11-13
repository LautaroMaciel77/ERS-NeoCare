using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class OrdenService
    {
        internal bool Insertar(OrdenModel orden)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Agregar el paciente al contexto
                context.orden.Add(orden);

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
        internal List<OrdenModel> traerOrdenes()
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Utiliza LINQ para consultar y obtener todas las órdenes en una lista
                List<OrdenModel> ordenes = context.orden.ToList();

                return ordenes;
            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error al traer órdenes: " + ex.Message);
                return new List<OrdenModel>(); // Retorna una lista vacía o maneja de otra manera apropiada
            }
        }
        internal void Buscar(string id)
        {

   
            int.TryParse(id, out int idInt);
            var context = DbContextManager.GetContext();

            var orden = context.orden.FirstOrDefault(u => u.Id == idInt);

            if (orden != null)
            {

                OrdenSingleton.Instance.Autenticar(orden);
            }
        }

        internal void CambiarEstado(int id)
        {
            var context = DbContextManager.GetContext();

            var turno = context.orden.SingleOrDefault(t => t.Id == id);

            if (turno != null)
            {
                // Cambiar el estado de "s" a "n" o de "n" a "s"
                turno.Estado = !turno.Estado;

                context.SaveChanges();
            }


        }
    }
}
