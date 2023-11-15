using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprmirPdf
{


    public  static class ContenidoHTML
    {

     
        public static string ObtenerContenidoHTML()
        {
       
            string encabezado = "Historia Clinica";

            //Historia clinica
            string historiaNumero = HistoriaClinicaSingleton.Instance.historiaAutenticado.Id.ToString();
            string historiaFechaInicio = HistoriaClinicaSingleton.Instance.historiaAutenticado.FechaInicio.ToString("dd/MM/yyyy");

            //Medico
            string medicoNombreYAp = HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Nombre + " " +
                                    HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Apellido;
            string medicoMatricula = HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Matricula.ToString();
            
            //Paciente
            string pacienteNombreYAp = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Nombre + " " +
                                    HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Apellido;
            string pacienteDni = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Dni.ToString();

            string pacienteFechaNac = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.FechaNacimiento.ToString("dd/MM/yyyy");
            string pacienteSexo = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Sexo;
            string pacienteDomicilio = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Domicilio;
            string pacienteObraSocial = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.ObraSocial;
            
            string pacienteTipoSangre = HistoriaClinicaSingleton.Instance.historiaAutenticado.TipoSangre;

            //Historia clinica
                //Familiares
            string antecedentes = HistoriaClinicaSingleton.Instance.historiaAutenticado.Familiares;
            string[] arregloAntecedentes = antecedentes.Split(';');
            StringBuilder listaAntecedentes = new StringBuilder("");
            foreach (string antecedente in arregloAntecedentes)
            {
                listaAntecedentes.Append($"<tr><td>{antecedente}</tr></td>");
            }
            

                //Medicamentos
            string medicamentos = HistoriaClinicaSingleton.Instance.historiaAutenticado.Medicamentos;
            string[] arregloMedicamentos = medicamentos.Split(';');
            StringBuilder listaMedicamentos = new StringBuilder("");
            foreach (string medicamento in arregloMedicamentos)
            {
                listaMedicamentos.Append($"<tr><td>{medicamento}</tr></td>");
            }
            

                //Alergias
            string alergias = HistoriaClinicaSingleton.Instance.historiaAutenticado.Alergias;
            string[] arregloAlergias = alergias.Split(';');
            StringBuilder listaAlergias = new StringBuilder("");
            foreach (string alergia in arregloAlergias)
            {
                listaAlergias.Append($"<tr><td>{alergia}</tr></td>");
            }

                //Historial
            
            List<HistorialModel> historiales = HistorialSingleton.Instance.historialesAutenticados;
            StringBuilder listaHistoriales = new StringBuilder("");
            if (historiales != null)
            {
                foreach (var historial in historiales)
                {
                    //string nombre = historial.Paciente.Nombre;
                    //string nombremedico = historial.Medico.Nombre;
                    //string tipo = historial.Tipo;
                    listaHistoriales.Append($"<tr><td>{historial.fecha}</td><td>{historial.Tipo}</tr></td>");
                    
                }
            }


            string contenidoHTML = $@"
            <html>
                <head>
                    <title>Historia Clinica - Nro. HC: {historiaNumero}</title>
                    <link rel='stylesheet' type='text/css' href='estilos.css' media='all'>
                </head>
            <body>
                <div class=""imagen-logo"">
                    <img src=""logo_hospital_eloisa_torrent.jpg"" alt=""logo-hospital""/>
                </div>
                <h1 class=""titulo-hc"">Historia Clinica</h1>
                    <div class=""datos-hc"">
                        <div>Fecha Inicio: {historiaFechaInicio}</div>
                        <div>Numero Historia Clinica: {historiaNumero}</div>
                    </div>
                <h2 class=""titulo-seccion-hc"">Datos</h2>
                <table>
                    <tbody>
                        <tr>
                            <th class=""titulo-tabla"" colspan=""2"">Medico de cabecera</th>
                        </tr>
                        <tr>
                            <td>Nombre y apellido: {medicoNombreYAp}</td>
                            <td>Matricula: {medicoMatricula}</td>
                        </tr>
                        <tr>
                            <th class=""titulo-tabla"" colspan=""4"">Paciente</th>
                        </tr>
                        <tr>
                            <td>Nombre y Apellido: {pacienteNombreYAp}</td>
                            <td>DNI: {pacienteDni}</td>
                        </tr>
                        <tr>
                            <td>Fecha de nacimiento: {pacienteFechaNac}</td>
                            <td>Sexo: {pacienteSexo}</td>
                        </tr>
                        <tr>
                            <td >Domicilio: {pacienteDomicilio}</td>
                            <td >Obra Social: {pacienteObraSocial}</td>
                        </tr>
                       <tr>
                            <td colspan=""2"">Tipo de sangre: {pacienteTipoSangre}</td>
                
                        </tr>
                          </tbody>
                          </table>
                            <h2 class=""titulo-seccion-hc"">Antecedentes</h2>
                        <table>
                          <tbody>
                        <tr>
                            <th class=""titulo-tabla"" colspan=""2"">Antecedentes medicos</th>
                        </tr>
                            {listaAntecedentes}
                        <tr>
                          <th  class=""titulo-tabla"" colspan=""2"">Alergias</th>
                        </tr>
                            {listaAlergias}
                        <tr>
                          <th class=""titulo-tabla"" colspan=""2"">Medicamentos</th>
                        </tr>
                           {listaMedicamentos}
                    </tbody>
                </table>
                <h2 class=""titulo-seccion-hc"">Historial de actuaciones medicas</h2>
                <table>
                    <tbody>
                        <tr>
                            <th class=""titulo-tabla"" colspan=""2"">Actuacion</th>
                        </tr>
                        <tr>
                            <td>Fecha</td>
                            <td>Descripcion</td>
                        </tr>  
                        {listaHistoriales}
                    </tbody>
                </table>
                <button class=""boton-imprimir"" onclick=""window.print()""><b>Imprimir <br>Historia Clinica</b></button>
            </body>
            </html>";

            return contenidoHTML;
        }
    }
}

