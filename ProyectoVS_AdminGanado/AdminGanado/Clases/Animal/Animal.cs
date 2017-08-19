using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    #region Propiedades
    /// <summary>
    /// Identificación del animal.
    /// </summary>
    [BsonId]
    public ObjectId _id { get; set; }

    public ObjectId _idGanado { get; set; }

    public char sexo { get; set; }

    public int edad { get; set; }

    public string identificador { get; set; }

    public double peso { get; set; }

    public string raza { get; set; }

    public int crias { get; set; }

    public string observaciones { get; set; }

    public string status { get; set; }

    public string salud { get; set; }
    #endregion
}

