using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CrudUsuario
{
    #region Atributos

    private static string NombreTabla = "Usuario";

    #endregion

    #region CRUD MongoDB

    #region Básico

    #region Registrar y Actualizar
    /// <summary>
    /// Registra o actualiza los datos de un usuario en MongoDB
    /// </summary>
    /// <param name="usuario">Objeto del tipo usuario</param>
    /// <returns>Regresa el id asignado al usuario registrado</returns>
    public ObjectId RegistrarUsuario(Usuario usuario)
    {
        ObjectId Id = new ObjectId();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        if (db[NombreTabla].Save(usuario, SafeMode.True).Ok)
        {
            Id = usuario._id;
        }
        return Id;
    }
    #endregion

    #region Obtener
    /// <summary>
    /// Obtiene los datos de un usuario especificado
    /// </summary>
    /// <param name="Id">Identificador del objeto que desea obtener</param>
    /// <returns></returns>
    public static Usuario ObtenerUsuario(ObjectId Id)
    {
        Usuario usuario = new Usuario();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Usuario>.EQ(n => n._id, Id);
        usuario = db[NombreTabla].FindAs<Usuario>(query).SingleOrDefault();
        return usuario;
    }

    public static List<Usuario> ObtenerUsuarios()
    {
        List<Usuario> usuarios = new List<Usuario>();
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        usuarios = db[NombreTabla].FindAllAs<Usuario>().ToList();
        return usuarios;        
    }
    #endregion

    #region Eliminar
    /// <summary>
    /// Elimina los datos del usuario especificado
    /// </summary>
    /// <param name="Id">Identificador del usuario que desea eliminar</param>
    /// <returns>Regresa 0 en caso de éxito</returns>
    public static int EliminarUsuario(ObjectId Id)
    {
        int resultado = -1;
        MongoDatabase db = Conexion.ObtenerConexionMongo();
        var query = Query<Usuario>.EQ(n => n._id, Id);
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

