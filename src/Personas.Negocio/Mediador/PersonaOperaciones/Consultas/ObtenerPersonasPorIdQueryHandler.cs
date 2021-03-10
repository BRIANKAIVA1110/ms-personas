using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Personas.Dominio.PersonasAgregados;
using Personas.Infraestructura;
using Personas.Negocio.Mediador.PersonaOperaciones.Consultas;
using Personas.Infraestructura.AccesoDatos.Consultas;
using Personas.Negocio.DTOs;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Consultas
{
    public class ObtenerPersonasPorIdQueryHandler : IRequestHandler<ObternerPersonaPorIdQuery, PersonaDTO>
    {
        private readonly IRepositoryBase<Persona> _repository;

        public ObtenerPersonasPorIdQueryHandler(IRepositoryBase<Persona> repository) 
        {
            this._repository = repository;
        }

        public Task<PersonaDTO> Handle(ObternerPersonaPorIdQuery request, CancellationToken cancellationToken)
        {
            var resultado = this._repository.ExecuteQuery(new ObtenerPersonaPorId(request.Id));

            var personaDto = new PersonaDTO
            {
                Id = resultado.Id,
                Nombre = resultado.Nombre,
                Apellido = resultado.Apellido
            };

            return Task.FromResult<PersonaDTO>(personaDto);
        }
    }
}
