using Personas.Dominio.PersonasAgregados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace Personas.Infraestructura.AccesoDatos.Comandos
{
    public class InsertarPersona:ICommand
    {
        private readonly Persona _persona;

        public InsertarPersona(Persona persona) {
            this._persona = persona;
        }

        public int Execute(IDbConnection connection)
        {
            //dispose???
            var sql = $"INSERT INTO PERSONAS VALUES(@nombre,@apellido)";
            var result = connection.Execute(sql, new { nombre = _persona.Nombre, apellido = _persona.Apellido });

            return result;
        }
    }
}
