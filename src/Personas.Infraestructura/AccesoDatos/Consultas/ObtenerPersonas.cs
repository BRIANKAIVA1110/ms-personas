using Personas.Dominio.PersonasAgregados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace Personas.Infraestructura.AccesoDatos.Consultas
{
    public class ObtenerPersonas:IQuery<IEnumerable<Persona>>
    {
        public ObtenerPersonas() { }

        public IEnumerable<Persona> Execute(IDbConnection connection)
        {
            var result = connection.Query<Persona>("select * from personas");

            return result;
        }
    }
}
