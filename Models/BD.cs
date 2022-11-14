using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace API_CHARE_SCHARNO.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-050; DataBase=Corki;Trusted_Connection=True;";

        public static List<Docente> GetDocentes()
        {
            List<Docente>? Lista = null;
            string SQL = "SELECT * FROM Skins"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Docente>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static Docente GetDocenteById(int Id)
        {
            Docente? item = null;
            string SQL = "SELECT * FROM Skins D INNER JOIN Categorias M ON D.IdMateria=M.IdMateria"; 
            SQL += " WHERE IdDocente=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Docente>(SQL, new { pId = Id }); 
            } 
            return item;
        }
        public static void DeleteDocenteById(int Id)
        {
            string SQL = "DELETE FROM Skins WHERE IdDocente=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new { pId = Id }); 
            } 
        }
        public static List<Materia> GetCategorias()
        {
            List<Materia>? Lista = null;
            string SQL = "SELECT * FROM Categorias"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Materia>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static void InsertDocente(Docente item)
        {
            string SQL = "INSERT INTO Skins(NombreDocente, FotoDocente, AntiguedadDocente, IdMateria)";
            SQL += " VALUES (@pNombreDocente, @pFotoDocente, @pAntiguedadDocente, @pIdMateria) "; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {
                    pNombreDocente = item.NombreDocente,
                    pFotoDocente = item.FotoDocente,
                    pAntiguedadDocente = item.AntiguedadDocente,
                    pIdMateria = item.IdMateria
                }); 
            }   
        }
        public static void InsertarEleccion()
        {

        }
    }
}