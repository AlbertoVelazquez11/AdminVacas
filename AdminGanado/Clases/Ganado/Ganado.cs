using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ganado
{
    #region Propiedades
    /// <summary>
    /// Identificación del Ganado.
    /// </summary>
    [BsonId]
    public ObjectId _id { get; set; }

    public ObjectId _idPropietario { get; set; }

    public int totalCabezas { get; set; }

    public int produccionLechera { get; set; }

    public int produccionCarne { get; set; }

    public int hembras { get; set; }

    public int machos { get; set; }

    public int terneras { get; set; }

    public string observaciones { get; set; }

    public DateTime fechaRegistro { get; set; }
    #endregion
}
