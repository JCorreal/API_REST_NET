using Api_Rest.DAL;

namespace Api_Rest.Controllers
{
    public static class AccesoDatosFactory
    {
        public static IAccesoDatos GetAccesoDatos()
        {
            return new AccesoDatos();
        }
    }
}