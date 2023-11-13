using System;

namespace ERS_NeoCare.Model
{
    using ERS_NeoCare.dbconexion;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Windows;

    public class UsuarioService
    {
        private string _connectionString;

        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UsuarioModel Authenticate(string nombreUsuario, string contraseña)
        {
            int.TryParse(nombreUsuario, out int dni);

            using (var context = new ApplicationDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.DNI == dni && u.Password == contraseña);

                if (usuario != null)
                {
                    context.Entry(usuario).Reference(u => u.Profesion).Load();
                    return usuario;
                }
                else
                {
                    // No se encontró un usuario que coincida con el nombre de usuario y contraseña.
                    // Puedes manejarlo de alguna manera, por ejemplo, retornar null o lanzar una excepción personalizada.
                    return null; // O podrías lanzar una excepción aquí si lo prefieres.
                }
            }
        }

        public void BuscarUsuario(string dni)

        {
            int.TryParse(dni, out int dniInt);
            var context = DbContextManager.GetContext();

            var usuario = context.Usuarios.FirstOrDefault(u => u.DNI == dniInt);

            if (usuario != null)
            {
                context.Entry(usuario).Reference(u => u.Profesion).Load();
                UsuarioBusqueda.Instance.AutenticarUsuario(usuario);
            }


        }


        public bool InsertarUsuario(UsuarioModel usuario)
        {
            {
                try
                {
                    var context = DbContextManager.GetContext();
                 
                    var user = new UsuarioModel
                        {
                            DNI = usuario.DNI,
                            Matricula = usuario.Matricula,
                            Nombre = usuario.Nombre,
                            Apellido = usuario.Apellido,
                            ProfesionID = usuario.ProfesionID,
                            Password = usuario.Password
                        };

                        // Agrega el nuevo usuario al contexto
                        context.Usuarios.Add(usuario);

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
        public bool EditarUsuario(UsuarioModel usuario)
        {
            try
            {
                var context = new ApplicationDbContext();
              
                    var user = context.Usuarios.FirstOrDefault(u => u.id == UsuarioSingleton.Instance.UsuarioAutenticado.id);

                    if (user != null)
                    {
                        // Actualiza los campos del usuario con los nuevos valores
                        user.DNI = usuario.DNI;
                        user.Matricula = usuario.Matricula;
                        user.Nombre = usuario.Nombre;
                        user.Apellido = usuario.Apellido;
                        user.ProfesionID = usuario.ProfesionID;
                        user.Password = usuario.Password;

                        // Guarda los cambios en la base de datos
                        context.SaveChanges();

                        return true;
                    
             
                }
                return false; // Si no se encuentra el usuario
            }
            catch (Exception ex)
            {
                // Maneja excepciones aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }
        public bool CambiarEstadoBajaUsuario()
        {

           int matricula= UsuarioSingleton.Instance.UsuarioAutenticado.Matricula;
            try
            {
                var context = new ApplicationDbContext();

                var user = context.Usuarios.FirstOrDefault(u => u.Matricula == matricula);

                if (user != null)
                {
                    // Cambia el estado de baja del usuario
                    user.Baja = (user.Baja == "n") ?"s" : "n";

                    // Guarda los cambios en la base de datos
                    context.SaveChanges();

                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                // excepción de SQL Server aquí.

                Console.WriteLine("Error de SQL: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
            catch (Exception ex)
            {
                // excepciones generales aquí.
                // excepciones de conexión, null reference, etc.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }
        public List<UsuarioModel> ObtenerDatosUsuarios(string valorBaja)
        {


            var context = DbContextManager.GetContext();

            var usuariosConBaja = context.Usuarios
                .Where(u => u.Baja == valorBaja)
                .ToList();



            return usuariosConBaja;
        }

    
    public List<UsuarioModel> ObtenerTodosLosUsuarios( )
    {


        var context = DbContextManager.GetContext();

        var usuariosConBaja = context.Usuarios.ToList();



        return usuariosConBaja;
    }
}
}
    


