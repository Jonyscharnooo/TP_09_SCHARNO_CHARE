using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace API_CHARE_SCHARNO.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-AMI-019; DataBase=Corki;Trusted_Connection=True;";
        static List<Materia> lista { get; }
        public static List<Skins> GetSkins()
        {
            List<Skins>? Lista = null;
            string SQL = "SELECT * FROM Skins"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Skins>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static Skins GetSkinById(int Id)
        {
            Skins? item = null;
            string SQL = "SELECT * FROM Skins D INNER JOIN Categorias M ON D.IdMateria=M.IdMateria"; 
            SQL += " WHERE IdSkin=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Skins>(SQL, new { pId = Id }); 
            } 
            return item;
        }
        public static void DeleteSkinById(int Id)
        {
            string SQL = "DELETE FROM Skins WHERE IdSkin=@pId"; 
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
        public static void InsertSkin(Skins item)
        {
            string SQL = "INSERT INTO Skins(NombreSkin, FotoSkin, AntiguedadSkin, IdMateria)";
            SQL += " VALUES (@pNombreSkin, @pFotoSkin, @pAntiguedadSkin, @pIdMateria) "; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {
                    pNombreSkin = item.NombreSkin,
                    pFotoSkin = item.FotoSkin,
                    pAntiguedadSkin = item.AntiguedadSkin,
                    pIdMateria = item.IdMateria
                }); 
            }   
        }
        public static Materia GetCateById(int Id)
        {
            Materia? item = null;
            string SQL = "SELECT * FROM Categorias D INNER JOIN Categorias M ON D.IdMateria=M.IdMateria"; 
            SQL += " WHERE IdMateria=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Materia>(SQL, new { pId = Id }); 
            } 
            return item;
        }
        public static void Update(Materia cate)
        {
            var index = lista.FindIndex(p => p.IdMateria == cate.IdMateria);
            if(index == -1)
                return;

            lista[index] = cate;
        }
    }
}