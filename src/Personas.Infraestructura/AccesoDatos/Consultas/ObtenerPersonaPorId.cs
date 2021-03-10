using Personas.Dominio.PersonasAgregados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Collections;
using System.Linq;

namespace Personas.Infraestructura.AccesoDatos.Consultas
{
    public class ObtenerPersonaPorId : IQuery<Persona>
    {
        private readonly int _id;

        public ObtenerPersonaPorId(int Id) 
        {
            this._id = Id;
        }

        public Persona Execute(IDbConnection connection)
        {
            //TODO: parametrizar query
            var result = connection.QueryFirstOrDefault<Persona>($"select * from personas where id = @Id ", new { Id = _id });

            return result;
        }
    }
}
