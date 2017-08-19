﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Usuario
{
    #region Propiedades
    /// <summary>
    /// Identificación del Usuario.
    /// </summary>
    [BsonId]
    public ObjectId _id { get; set; }

    public string nombre { get; set; }

    public string correo { get; set; }

    public string contraseña { get; set; }

    public string tipo { get; set; }
    #endregion
}