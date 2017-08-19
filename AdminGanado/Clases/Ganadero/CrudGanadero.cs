using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrudGanadero
{
    #region Atributos

    private static string NombreTabla = "Ganadero";

    #endregion

    #region CRUD MongoDB

    #region Básico

    #region Registrar y Actualizar
    /// <summary>
    /// Registra o actualiza los datos de un ganadero en MongoDB
    /// </summary>
    /// <param name="ganadero">Objeto del tipo ganadero</param>
    /// <returns>Regresa el id asignado al ganadero registrado</returns>
    public ObjectId RegistrarGanadero(Ganadero ganadero)
    {
        ObjectId Id = new ObjectId();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        if (db[NombreTabla].Save(ganadero, SafeMode.True).Ok)
        {
            Id = ganadero._id;
        }
        return Id;
    }
    #endregion

    #region Obtener
    /// <summary>
    /// Obtiene los datos de un ganadero especificado
    /// </summary>
    /// <param name="Id">Identificador del objeto que desea obtener</param>
    /// <returns></returns>
    public static Ganadero ObtenerGanadero(ObjectId Id)
    {
        Ganadero ganadero = new Ganadero();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Ganadero>.EQ(n => n._id, Id);
        ganadero = db[NombreTabla].FindAs<Ganadero>(query).SingleOrDefault();
        return ganadero;
    }
    public static List<Ganadero> ObtenerGanaderos()
    {
        List<Ganadero> ganaderos = new List<Ganadero>();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        ganaderos = db[NombreTabla].FindAllAs<Ganadero>().ToList();
        return ganaderos;
    }

    #endregion

    #region Eliminar
    /// <summary>
    /// Elimina los datos del ganadero especificado
    /// </summary>
    /// <param name="Id">Identificador del ganadero que desea eliminar</param>
    /// <returns>Regresa 0 en caso de éxito</returns>
    public static int EliminarGanadero(ObjectId Id)
    {
        int resultado = -1;
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Ganadero>.EQ(n => n._id, Id);
        if (db[NombreTabla].Remove(query, SafeMode.True).DocumentsAffected > 0)
        {
            resultado = 0;
        }
        return resultado;
    }
    #endregion

    #endregion

    #endregion
}

