using System;
namespace API_CHARE_SCHARNO.Models
{
    public class Elecciones
    {
        private int _IdElecciones;
        public int IdElecciones { get { return _IdElecciones;} set { _IdElecciones = value;}}

        private int _ParteAr;
        public int ParteAr { get { return _ParteAr;} set { _ParteAr = value;}}

        private int _ParteMe;
        public int ParteMe { get { return _ParteMe;} set { _ParteMe = value;}}

        private int _ParteAb;
        public int ParteAb { get { return _ParteAb;} set { _ParteAb = value;}}
        
    }
}