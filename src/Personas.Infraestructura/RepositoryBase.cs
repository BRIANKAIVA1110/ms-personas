﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Personas.Infraestructura
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T:class,new()
    {
        private readonly IDbConnection _connection;

        public RepositoryBase(IDbConnection connection)
        {
            this._connection = connection;
        }

        /// <summary>
        /// metodo para ejecutar consultas etc... prototipo
        /// </summary>
        /// <typeparam name="W"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public W ExecuteQuery<W>(IQuery<W> query) where W:class
        {
            var result = query.Execute(_connection);

            return result;
        }
    }
}
