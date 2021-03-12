using MediatR;
using Personas.Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Consultas
{
    public class ObtenerPersonasQuery: IRequest<IEnumerable<PersonaDTO>>
    {
    }
}
