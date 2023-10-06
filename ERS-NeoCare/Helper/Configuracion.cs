namespace ERS_NeoCare.Helper
{

    public class Configuracion
    {
        public static string ConnectionString { get; } = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        //public static string ConnectionString { get; } = "Data Source=(FARONOTE\SQLEXPRESS_INST1)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

    }

}
