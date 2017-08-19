using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrudOrganizacion
{
    #region Atributos

    private static string NombreTabla = "Organizacion";

    #endregion

    #region CRUD MongoDB

    #region Básico

    #region Registrar y Actualizar
    /// <summary>
    /// Registra o actualiza los datos de un organizacion en MongoDB
    /// </summary>
    /// <param name="organizacion">Objeto del tipo organizacion</param>
    /// <returns>Regresa el id asignado al organizacion registrado</returns>
    public ObjectId RegistrarOrganizacion(Organizacion organizacion)
    {
        ObjectId Id = new ObjectId();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        if (db[NombreTabla].Save(organizacion, SafeMode.True).Ok)
        {
            Id = organizacion._id;
        }
        return Id;
    }
    #endregion

    #region Obtener
    /// <summary>
    /// Obtiene los datos de un organizacion especificado
    /// </summary>
    /// <param name="Id">Identificador del objeto que desea obtener</param>
    /// <returns></returns>
    public static Organizacion ObtenerOrganizacion(ObjectId Id)
    {
        Organizacion organizacion = new Organizacion();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Organizacion>.EQ(n => n._id, Id);
        organizacion = db[NombreTabla].FindAs<Organizacion>(query).SingleOrDefault();
        return organizacion;
    }

    public static List<Organizacion> ObtenerOrganizaciones()
    {
        List<Organizacion> organizaciones = new List<Organizacion>();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        organizaciones = db[NombreTabla].FindAllAs<Organizacion>().ToList();
        return organizaciones;
    }
    #endregion

    #region Eliminar
    /// <summary>
    /// Elimina los datos del organizacion especificado
    /// </summary>
    /// <param name="Id">Identificador del organizacion que desea eliminar</param>
    /// <returns>Regresa 0 en caso de éxito</returns>
    public static int EliminarOrganizacion(ObjectId Id)
    {
        int resultado = -1;
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Organizacion>.EQ(n => n._id, Id);
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