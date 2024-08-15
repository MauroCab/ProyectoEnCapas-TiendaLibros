using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos
        private int codUsuario;
        private string nombre;
        private string correoElectronico;
        private string direccionDeEnvio;
        private Libro[] carritoDeCompras;
        #endregion

        #region Constructor
        public Usuario()
        {
            codUsuario = 0;
            nombre = string.Empty;
            correoElectronico = string.Empty;
            direccionDeEnvio = string.Empty;
            carritoDeCompras = new Libro[0];
        }
        #endregion

        #region Propiedades/Encapsulamiento
        public int CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        public string DireccionDeEnvio
        {
            get { return direccionDeEnvio; }
            set { direccionDeEnvio = value; }
        }
        public Libro[] CarritoDeCompras
        {
            get { return carritoDeCompras; }
            set { carritoDeCompras = value; }
        }
        #endregion
    }
}
