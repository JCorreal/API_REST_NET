using Api_Rest.BLL;

namespace Api_Rest.Controllers
{
    public class Funciones
    {
        public static Controlador CrearControlador()
        {
            var accesoDatos = AccesoDatosFactory.GetAccesoDatos();
            return new Controlador(accesoDatos);
        }
    }

}