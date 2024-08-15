using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Entidades;


namespace Datos.Tablas
{
    public class DatosUsuarios : DatosConexionBD
    {
        public int abmUsuarios(string accion, Usuario objUsuario)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                string carrito = string.Join(",", objUsuario.CarritoDeCompras.Select(libro => libro.Titulo));

                orden = "insert into Usuarios (CodUsuario, Nombre, CorreoElectronico, DireccionDeEnvio, CarritoDeCompras) values (" +
                        objUsuario.CodUsuario + ", '" +
                        objUsuario.Nombre + "', '" +
                        objUsuario.CorreoElectronico + "', '" +
                        objUsuario.DireccionDeEnvio + "', '" +
                        carrito + "');";
            }

            if (accion == "Modificar")
            {
                string carrito = string.Join(",", objUsuario.CarritoDeCompras.Select(libro => libro.Titulo));

                orden = "update Usuarios set " +
                        "Nombre = '" + objUsuario.Nombre + "', " +
                        "CorreoElectronico = '" + objUsuario.CorreoElectronico + "', " +
                        "DireccionDeEnvio = '" + objUsuario.DireccionDeEnvio + "', " +
                        "CarritoDeCompras = '" + carrito + "' " +
                        "where CodUsuario = " + objUsuario.CodUsuario + ";";
            }

            if (accion == "Borrar")
            {
                orden = "delete from Usuarios where CodUsuario = " + objUsuario.CodUsuario + ";";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar en Usuarios", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public DataSet listadoUsuarios(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
            {
                orden = "select * from Usuarios where CodUsuario = " + int.Parse(cual) + ";";
            }
            else
            {
                orden = "select * from Usuarios;";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Usuarios", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return ds;
        }

    }
}

