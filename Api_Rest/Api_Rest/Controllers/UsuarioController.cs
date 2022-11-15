using System.Collections.Generic;
using System.Web.Http;
using System;
using Api_Rest.Models;

namespace Api_Rest.Controllers
{
    public class UsuarioController : ApiController
    {
        // Visualizar todos los Usuarios
        // GET: api/Usuario/ 
        public List<Usuario> Get()
        {
            Controlador controlador = Funciones.CrearControlador();
            List<Usuario> listausuarios;
            listausuarios = controlador.ObtenerListadoUsuarios();
            return listausuarios;
        }

        // Visualizar un Usuario
        // GET: api/Usuario/id
        public Usuario Get(int id)
        {
            Controlador controlador = Funciones.CrearControlador();
            Usuario usuario = (Usuario)controlador.ObtenerUsuario(id);
            return usuario;
        }

        // Crear un Usuario
        // POST: api/Usuario/
        public string Post([FromBody]Usuario usuario)
        {
            int Resultado = 0;
            string Respuesta = null;
            try
            {
                Controlador controlador = Funciones.CrearControlador();
                Resultado = controlador.GuardarUsuario(usuario);
                if (Resultado == 0)
                {
                    Respuesta = "Registro Grabado Satisfactoriamente";
                }
                else
                {
                    Respuesta = "Error, Se ha producido un error accesando la base de datos";
                }
            }
            catch (Exception e)
            {
                Respuesta = "Error Desconocido"+e;
            }
            return Respuesta;
        }


        // Actualizar un Usuario
        // PUT: api/Usuario/id
        public string Put([FromBody]Usuario usuario) 
        {
            int Resultado = 0;
            string Respuesta = null;
            try
            {                
                Controlador controlador = Funciones.CrearControlador();
                Resultado = controlador.GuardarUsuario(usuario);
                if (Resultado == 0)
                {
                    Respuesta = "Registro Actualizado Satisfactoriamente";
                }
                else if (Resultado == -2)
                {
                    Respuesta = "Error, no existe este usuario";
                }
                else
                {
                    Respuesta = "Error, Se ha producido un error accesando la base de datos";
                }
            }
            catch (Exception e)
            {
                Respuesta = "Error Desconocido" + e;
            }
            return Respuesta;

        }

        // Eliminar un Usuario
        // GET: api/Usuario/id
        public string Delete(int id)
        {
            int Resultado = 0;
            string Respuesta = null;
            try
            {

                Controlador controlador = Funciones.CrearControlador();
                Resultado = controlador.EliminarUsuario(id);
                if (Resultado == 0)
                {
                    Respuesta="Registro Eliminado Satisfactoriamente";

                }
                else if (Resultado == -2)
                {
                    Respuesta = "Error, no existe este usuario";
                }
                else
                {
                    Respuesta = "Error, Se ha producido un error accesando la base de datos";
                }
            }
            catch (Exception e)
            {
                Respuesta = "Error Desconocido" +e;
            }
            return Respuesta;
        }

        
    }
}
