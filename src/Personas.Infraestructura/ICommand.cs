using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Personas.Infraestructura
{
    public interface ICommand
    {
        int Execute(IDbConnection connection);
    }
}
