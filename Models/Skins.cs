using System;
namespace API_CHARE_SCHARNO.Models
{
    public class Skins
    {
        private int _IdSkin;
        public int IdSkin { get { return _IdSkin;} set { _IdSkin = value;}}

        private string? _NombreSkin;
        public string? NombreSkin { get { return _NombreSkin;} set { _NombreSkin = value;}}

        private string? _FotoSkin;
        public string? FotoSkin { get { return _FotoSkin;} set { _FotoSkin = value;}}
        
        private int? _AntiguedadSkin;
        public int? AntiguedadSkin { get { return _AntiguedadSkin;} set { _AntiguedadSkin = value;}}

    }
}