using System;
namespace API_CHARE_SCHARNO.Models
{
    public class Docente
    {
        private int _IdDocente;
        public int IdDocente { get { return _IdDocente;} set { _IdDocente = value;}}

        private string? _NombreDocente;
        public string? NombreDocente { get { return _NombreDocente;} set { _NombreDocente = value;}}

        private string? _FotoDocente;
        public string? FotoDocente { get { return _FotoDocente;} set { _FotoDocente = value;}}

        private int _IdMateria;
        public int IdMateria { get { return _IdMateria;} set { _IdMateria = value;}}
        private string? _NombreMateria;
        public string? NombreMateria { get { return _NombreMateria;} set { _NombreMateria = value;}}

        private int _AntiguedadDocente;
        public int AntiguedadDocente { get { return _AntiguedadDocente;} set { _AntiguedadDocente = value;}}

    }
}