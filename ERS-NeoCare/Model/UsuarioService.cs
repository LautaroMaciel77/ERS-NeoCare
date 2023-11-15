using System;

namespace ERS_NeoCare.Model
{
    using ERS_NeoCare.dbconexion;
    using ERS_NeoCare.Helper;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Forms;

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
                string hashedPassword = Encrypt.GetSHA256(contraseña);

                 var usuario = context.Usuarios.FirstOrDefault(u => u.DNI == dni &&( (u.Password == hashedPassword) ||(u.Password == contraseña)));

                if (usuario != null)
                {
                    context.Entry(usuario).Reference(u => u.Profesion).Load();
                    return usuario;
                }
                else
                {
       
                    return null;
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
            try
            {
                var context = DbContextManager.GetContext();

                //  GetSHA256 para cifrar la contraseña
                string hashedPassword = Encrypt.GetSHA256(usuario.Password);

       
                var user = new UsuarioModel
                {
                    DNI = usuario.DNI,
                    Matricula = usuario.Matricula,
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    ProfesionID = usuario.ProfesionID,
                    Password = hashedPassword, // Asigna el hash SHA-256 cifrado
                    Baja = usuario.Baja
                };

            
                context.Usuarios.Add(user);

               
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
          
                // Muestra un MessageBox con el mensaje de la excepción
                System.Windows.Forms.MessageBox.Show("Error al insertar usuario: " + ObtenerMensajeExcepcion(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine("Error general: " + ex.Message);
                return false; 
            }
        }

        private string ObtenerMensajeExcepcion(Exception ex)
        {
            string mensaje = ex.Message;

            // Verifica si hay una excepción interna
            if (ex.InnerException != null)
            {
                mensaje += " " + ObtenerMensajeExcepcion(ex.InnerException);
            }

            return mensaje;
        }
        public bool EditarUsuario(UsuarioModel usuario)
        {
            try
            {
                var context = DbContextManager.GetContext();

            
                var user = context.Usuarios.FirstOrDefault(u => u.id == UsuarioBusqueda.Instance.UsuarioAutenticado.id);

                if (user != null)
                {
     
                    user.DNI = usuario.DNI;
                    user.Matricula = usuario.Matricula;
                    user.Nombre = usuario.Nombre;
                    user.Apellido = usuario.Apellido;
             

                 
                    if (!string.IsNullOrWhiteSpace(usuario.Password))
                    {
                    
                        user.Password = Encrypt.GetSHA256(usuario.Password);
                    }

                    // Guarda los cambios en la base de datos


                    int filasModificadas = context.SaveChanges();

                    return filasModificadas > 0;
                }

                return false; // Si no se encuentra el usuario
            }
            catch (Exception ex)
            {
                

                // Muestra un cuadro de mensaje con el mensaje de la excepción actual y sus excepciones internas
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendLine($"Error: {ex.Message}");

                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    errorMessage.AppendLine($"Inner Exception: {innerException.Message}");
                    innerException = innerException.InnerException;
                }

                System.Windows.Forms.MessageBox.Show(errorMessage.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                return false;
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

                
                    context.SaveChanges();

                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                // excepción de SQL Server aquí.

                Console.WriteLine("Error de SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // excepciones generales aquí.
                // excepciones de conexión, null reference, etc.
                Console.WriteLine("Error general: " + ex.Message);
                return false; 
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
    


