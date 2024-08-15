namespace Entidades
{
    public class Libro
    {
        #region Atributos
        private int codLibro;
        private string titulo;
        private string autor;
        private string genero;
        private decimal precio;
        private int cantidadStock;
        #endregion

        #region Constructor
        public Libro()
        {
            codLibro = 0;
            titulo = string.Empty;
            autor = string.Empty;
            genero = string.Empty;
            precio = 0;
            cantidadStock = 0;
        }
        #endregion

        #region propiedades/encapsulamiento
        public int CodLibro
        {
            get { return codLibro; }
            set { codLibro = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int CantidadStock
        {
            get { return cantidadStock; }
            set { cantidadStock = value; }
        }
        #endregion
    }
}
