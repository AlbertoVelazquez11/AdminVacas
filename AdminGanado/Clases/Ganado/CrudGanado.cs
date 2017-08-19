using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrudGanado
{
    #region Atributos

    private static string NombreTabla = "Ganado";

    #endregion

    #region CRUD MongoDB

    #region Básico

    #region Registrar y Actualizar
    /// <summary>
    /// Registra o actualiza los datos de un Ganado en MongoDB
    /// </summary>
    /// <param name="Ganado">Objeto del tipo Ganado</param>
    /// <returns>Regresa el id asignado al Ganado registrado</returns>
    public static ObjectId RegistrarGanado(Ganado Ganado)
    {
        ObjectId Id = new ObjectId();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        if (db[NombreTabla].Save(Ganado, SafeMode.True).Ok)
        {
            Id = Ganado._id;
        }
        return Id;
    }
    #endregion

    #region Obtener
    /// <summary>
    /// Obtiene los datos de un Ganado especificado
    /// </summary>
    /// <param name="Id">Identificador del objeto que desea obtener</param>
    /// <returns></returns>
    public static Ganado ObtenerGanado(ObjectId Id)
    {
        Ganado Ganado = new Ganado();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Ganado>.EQ(n => n._id, Id);
        Ganado = db[NombreTabla].FindAs<Ganado>(query).SingleOrDefault();
        return Ganado;
    }

    public static List<Ganado> ObtenerGanados()
    {
        List<Ganado> ganado = new List<Ganado>();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        ganado = db[NombreTabla].FindAllAs<Ganado>().ToList();
        return ganado;
    }
    #endregion

    #region Eliminar
    /// <summary>
    /// Elimina los datos del Ganado especificado
    /// </summary>
    /// <param name="Id">Identificador del Ganado que desea eliminar</param>
    /// <returns>Regresa 0 en caso de éxito</returns>
    public static int EliminarGanado(ObjectId Id)
    {
        int resultado = -1;
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Ganado>.EQ(n => n._id, Id);
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