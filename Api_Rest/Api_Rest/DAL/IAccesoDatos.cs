using Api_Rest.Models;
using System.Collections.Generic;

namespace Api_Rest.DAL
{
    public interface IAccesoDatos
    {
        List<Usuario> ObtenerListadoUsuarios();
        Usuario ObtenerUsuario(int DatoBuscar);
        int GuardarUsuario(Usuario usuaurio);
        int EliminarUsuario(int DatoEliminar);
    }
}
