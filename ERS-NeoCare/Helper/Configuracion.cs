﻿using System.Windows.Markup;

namespace ERS_NeoCare.Helper
{

    public class Configuracion
    {
        public static string ConnectionString { get; } = "Data Source=FARONOTE\\SQLEXPRESS_INST1;Initial Catalog=DBNeoCare;Integrated Security=True";


        //public static string ConnectionString { get; } = "Data Source=(FARONOTE\SQLEXPRESS_INST1)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

    }

}
