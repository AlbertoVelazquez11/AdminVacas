using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Conexion
{
    public static MongoDatabase ObtenerConexionMongo()
    {
        string cadenaConexion = "mongodb://localhost";
        MongoServer servidor = MongoServer.Create(cadenaConexion);
        MongoDatabase db = servidor.GetDatabase("SASG");
        return db;
    }
}
