﻿using ERS_NeoCare.Design.administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class AtencionService
    {





        internal bool Insertar(AtencionEnfermeriaModel atencion)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Agregar la orden al contexto
                context.atencion.Add(atencion);

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
        internal List<AtencionEnfermeriaModel> ObtenerAtenciones()
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Consultar la tabla de análisis y traer todos los registros
                List<AtencionEnfermeriaModel> analisis = context.atencion.ToList();

                return analisis;
            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return null; // O maneja de otra manera apropiada, como lanzar una excepción
            }
        }
    }
}
