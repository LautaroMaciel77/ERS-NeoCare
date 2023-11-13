using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprmirPdf
{
    public static class EstilosCSS
    {
        public static string ObtenerEstilosCSS()
        {
            string estilosCSS = @"
            body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }

        table {
            width: 80%;
            border-collapse: collapse;
            margin-bottom: 20px;
            margin:auto;
        }

        th, td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }

        th {
            background-color: #f2f2f2;
        }

        .total {
            font-weight: bold;
        }

        .titulo-hc{
            margin: auto;
            text-align: center;
            margin-top:10px;
            margin-bottom:10px;
        }
        .titulo-seccion-hc{
            margin: auto;
            text-align: center;
            margin-top:40px;
            margin-bottom:10px;
        }
        .titulo-tabla{
            text-align:center
        }
        .datos-hc{
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            text-align: center;
        }
        .imagen-logo {
            text-align: center;
        }

        .imagen-logo img {
            display: inline-block;
            width: 10%; 
            height: auto;
        }
        .boton-imprimir {
            position: fixed;
            bottom: 20px;
            right: 20px;
            background-color: #00BF9E;
            color: white;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        @media print {
            .boton-imprimir {
                display: none;
            }
        }

";

            return estilosCSS;
        }
    }
}
