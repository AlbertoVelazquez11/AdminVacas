using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Organizacion
{
    #region Propiedades
    /// <summary>
    /// Identificación de la organización.
    /// </summary>
    [BsonId]
    public ObjectId _id { get; set; }

    public string nombre { get; set; }

    public string estatus { get; set; }

    public string correo { get; set; }

    public string telefono { get; set; }

    public string direccion { get; set; }
    #endregion
}

