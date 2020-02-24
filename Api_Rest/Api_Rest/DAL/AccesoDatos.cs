using Api_Rest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Api_Rest.DAL
{
    public class AccesoDatos : IAccesoDatos
    {
        // Default Constructor
        public AccesoDatos() { }
        private List<Usuario> ListaUsuarios;

        private SqlConnection Cn;   // Conexion 
        private SqlDataReader sdr;  // Cursor - Recordset de solo lectura
        private SqlCommand Cmd;     // Objeto de tipo Command para acceder a Procedimientos Almacenados        

        public Usuario ObtenerUsuario(int DatoBuscar)
        {
            Usuario usuario = new Usuario();
            try
            {
                Cn = new SqlConnection(Conexion.obtenerConexion);
                Cmd = new SqlCommand("spr_Listados", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("p_Usuario_Id", SqlDbType.Int, 11).Value = DatoBuscar;
                Cn.Open();
                sdr = Cmd.ExecuteReader();
                if (sdr.Read())
                {
                    usuario.usuario_id = Convert.ToInt32(sdr["USUARIO_ID"].ToString());
                    usuario.nombres = sdr["NOMBRES"].ToString();
                    usuario.apellidos = sdr["APELLIDOS"].ToString();
                }
                else
                {
                    usuario = null;
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public List<Usuario> ObtenerListadoUsuarios()
        {
            ListaUsuarios = new List<Usuario>();
            try
            {
                using (SqlConnection Cn = new SqlConnection(Conexion.obtenerConexion))
                {
                    Cmd = new SqlCommand("spr_Listados", Cn);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("p_Usuario_Id", SqlDbType.Int, 11).Value = 0;
                    Cn.Open();
                    using (sdr = Cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        while (sdr.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.usuario_id = Convert.ToInt32(sdr.GetValue(0).ToString());
                            usuario.nombres = sdr.GetValue(1).ToString();
                            usuario.apellidos = sdr.GetValue(2).ToString();
                            ListaUsuarios.Add(usuario);
                        }
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaUsuarios;
        }

        public int GuardarUsuario(Usuario usuario)
        {
            int Resultado = -1;
            try
            {
                using (SqlConnection Cn = new SqlConnection(Conexion.obtenerConexion))
                {
                    Cmd = new SqlCommand("spr_IUUsuarios", Cn);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("p_Usuario_Id", SqlDbType.Int, 11).Value = usuario.usuario_id;
                    Cmd.Parameters.Add("p_Nombres", SqlDbType.VarChar, 25).Value = usuario.nombres;
                    Cmd.Parameters.Add("p_Apellidos", SqlDbType.VarChar, 25).Value = usuario.apellidos;
                    Cmd.Parameters.Add("p_Resultado", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                    Cn.Open();
                    Cmd.ExecuteNonQuery();
                    Resultado = Convert.ToInt32(Cmd.Parameters["p_Resultado"].Value);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return Resultado;
        }

        public int EliminarUsuario(int DatoEliminar)
        {
            int Resultado = 0;
            try
            {
                using (SqlConnection Cn = new SqlConnection(Conexion.obtenerConexion))
                {
                    Cmd = new SqlCommand("spr_DUsuario", Cn);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("p_Usuario_Id", SqlDbType.Int, 11).Value = DatoEliminar;
                    Cmd.Parameters.Add("p_Resultado", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                    Cn.Open();
                    Cmd.ExecuteNonQuery();
                    Resultado = Convert.ToInt32(Cmd.Parameters["p_Resultado"].Value);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return Resultado;
        }
    }
}


