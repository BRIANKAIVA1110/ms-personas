using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Personas.Negocio.DTOs;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Consultas
{
    public class ObternerPersonaPorIdQuery: IRequest<PersonaDTO>
    {
        public int Id { get; set; }

        public ObternerPersonaPorIdQuery(int Id)
        {
            this.Id = Id;
        }
    }
}
