using System.Data;
using Datos;
using Datos.Tablas;
using Entidades;

namespace Negocios
{
    public class NegLibros
    {
        DatosLibros objDatosLibros = new DatosLibros();

        public int abmLibros(string accion, Libro objLibro)
        {
            return objDatosLibros.abmLibros(accion, objLibro);
        }
        public DataSet listadoLibros(string cual)
        {
            return objDatosLibros.listadoLibros(cual);
        }
    }
}
