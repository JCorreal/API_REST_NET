using Api_Rest.Controllers;

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
