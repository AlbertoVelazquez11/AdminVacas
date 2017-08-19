using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrudAnimal
{
    #region Atributos

    private static string NombreTabla = "Animal";

    #endregion

    #region CRUD MongoDB

    #region Básico

    #region Registrar y Actualizar
    /// <summary>
    /// Registra o actualiza los datos de un animal en MongoDB
    /// </summary>
    /// <param name="animal">Objeto del tipo animal</param>
    /// <returns>Regresa el id asignado al animal registrado</returns>
    public ObjectId RegistrarAnimal(Animal animal)
    {
        ObjectId Id = new ObjectId();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        if (db[NombreTabla].Save(animal, SafeMode.True).Ok)
        {
            Id = animal._id;
        }
        return Id;
    }
    #endregion

    #region Obtener
    /// <summary>
    /// Obtiene los datos de un animal especificado
    /// </summary>
    /// <param name="Id">Identificador del objeto que desea obtener</param>
    /// <returns></returns>
    public static Animal ObtenerAnimal(ObjectId Id)
    {
        Animal animal = new Animal();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Animal>.EQ(n => n._id, Id);
        animal = db[NombreTabla].FindAs<Animal>(query).SingleOrDefault();
        return animal;
    }

    public static List<Animal> ObtenerAnimales()
    {
        List<Animal> animales = new List<Animal>();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        animales = db[NombreTabla].FindAllAs<Animal>().ToList();
        return animales;
    }
    #endregion

    #region Eliminar
    /// <summary>
    /// Elimina los datos del animal especificado
    /// </summary>
    /// <param name="Id">Identificador del animal que desea eliminar</param>
    /// <returns>Regresa 0 en caso de éxito</returns>
    public static int EliminarAnimal(ObjectId Id)
    {
        int resultado = -1;
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Animal>.EQ(n => n._id, Id);
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

