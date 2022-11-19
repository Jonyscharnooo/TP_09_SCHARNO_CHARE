using System;
namespace API_CHARE_SCHARNO.Models
{
    public class Categorias
    {
        private int _IdCategoria;
        public int IdMateria { get { return _IdMateria;} set { _IdMateria = value;}}

        private string? _NombreCategoria;
        public string? NombreCategoria { get { return _NombreCategoria;} set { _NombreCategoria = value;}}

        private int _Precio;
        public int Precio { get { return _Precio;} set { _Precio = value;}}
    }
}