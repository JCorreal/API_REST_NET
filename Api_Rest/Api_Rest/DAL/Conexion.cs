namespace Api_Rest.DAL
{
    public class Conexion
    {
        public static string obtenerConexion
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ToString();
            }
        }

    }
}