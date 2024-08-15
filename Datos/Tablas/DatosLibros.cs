using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;
using System.Data.SqlClient;

namespace Datos.Tablas
{
    public class DatosLibros : DatosConexionBD
    {
        public int abmLibros(string accion, Libro objLibro)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "insert into Libros (CodLibro, Titulo, Autor, Genero, Precio, CantidadStock) values (" +
                objLibro.CodLibro + ", '" +
                objLibro.Titulo + "', '" +
                objLibro.Autor + "', '" +
                objLibro.Genero + "', " +
                objLibro.Precio + ", " +
                objLibro.CantidadStock + ");";
            }

            if (accion == "Modificar")
            {
                orden = "update Libros set " +
                "Titulo = '" + objLibro.Titulo + "', " +
                "Autor = '" + objLibro.Autor + "', " +
                "Genero = '" + objLibro.Genero + "', " +
                "Precio = " + objLibro.Precio + ", " +
                "CantidadStock = " + objLibro.CantidadStock +
                " where CodLibro = " + objLibro.CodLibro + ";";
            }

            // falta la orden de borrar

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar de Libros", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }
        public DataSet listadoLibros(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
            {
                orden = "select * from Libros where CodLibro = " + int.Parse(cual) + ";";
            }

            else
            {
                orden = "select * from Libros;";
            }
                
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Libros", e);
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
