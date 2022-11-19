using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace API_CHARE_SCHARNO.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=DESKTOP-3G0NGRC\SQLEXPRESS; DataBase=Corki;Trusted_Connection=True;";
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
            string SQL = "SELECT * FROM Skins D INNER JOIN Categorias M ON D.IdCategoria=M.IdCategoria"; 
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
        public static List<Categorias> GetCategorias()
        {
            List<Categorias>? Lista = null;
            string SQL = "SELECT * FROM Categorias"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Categorias>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static void InsertSkin(Skins item)
        {
            string SQL = "INSERT INTO Skins(NombreSkin, FotoSkin, AntiguedadSkin)";
            SQL += " VALUES (@pNombreSkin, @pFotoSkin, @pAntiguedadSkin) "; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {
                    pNombreSkin = item.NombreSkin,
                    pFotoSkin = item.FotoSkin,
                    pAntiguedadSkin = item.AntiguedadSkin
                }); 
            }   
        }
        public static void UpdateSkin(int id, Skins item)
        {
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute("UPDATE Skins SET NombreSkin = @pNombreSkin, FotoSkin =  @pFotoSkin, AntiguedadSkin =  @pAntiguedadSkin WHERE IdSkin = @pId", 
                new { pId = id, pNombreSkin = item.NombreSkin, pFotoSkin = item.FotoSkin, pAntiguedadSkin = item.AntiguedadSkin }); 
            }   
        }
    }
}