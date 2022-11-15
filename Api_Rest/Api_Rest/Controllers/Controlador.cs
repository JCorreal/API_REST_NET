using Api_Rest.DAL;
using Api_Rest.Models;
using System.Collections.Generic;

namespace Api_Rest.Controllers
{
    public class Controlador
    {
        private readonly IAccesoDatos _accesoDatos;

        public Controlador(IAccesoDatos accesoDatos)
        {
            _accesoDatos = accesoDatos;
        }

        public List<Usuario> ObtenerListadoUsuarios()
        {
            return _accesoDatos.ObtenerListadoUsuarios();
        }

        public Usuario ObtenerUsuario(int DatoBuscar)
        {
            return _accesoDatos.ObtenerUsuario(DatoBuscar);
        }

        public int GuardarUsuario(Usuario usuario)
        {
            return _accesoDatos.GuardarUsuario(usuario);
        }

        // Eliminar Registro
        public int EliminarUsuario(int DatoEliminar)
        {
            return _accesoDatos.EliminarUsuario(DatoEliminar);
        }
    }
}
