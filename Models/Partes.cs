using System;
namespace API_CHARE_SCHARNO.Models
{
    public class Partes
    {
        private int _IdPartes;
        public int IdPartes { get { return _IdPartes;} set { _IdPartes = value;}}

        private string? _NombreP;
        public string? NombreP { get { return _NombreP;} set { _NombreP = value;}}

        private string? _Link;
        public string? Link { get { return _Link;} set { _Link = value;}}
        
    }
}