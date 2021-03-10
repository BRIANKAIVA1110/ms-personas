using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Personas.Dominio.PersonasAgregados;
using Personas.Infraestructura;
using Personas.Infraestructura.AccesoDatos.Consultas;
using Personas.Negocio.DTOs;
using System.Linq;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Consultas
{
    public class ObtenerPersonasQueryHandler : IRequestHandler<ObtenerPersonasQuery, IEnumerable<PersonaDTO>>
    {
        private readonly IRepositoryBase<Persona> _repository;

        public ObtenerPersonasQueryHandler(IRepositoryBase<Persona> repository) 
        {
            this._repository = repository;
        }
        public Task<IEnumerable<PersonaDTO>> Handle(ObtenerPersonasQuery request, CancellationToken cancellationToken)
        {

            var listPersonas = _repository.ExecuteQuery(new ObtenerPersonas())
                .Select(x => new PersonaDTO
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido
                });

            return Task.FromResult<IEnumerable<PersonaDTO>>(listPersonas);

        }
    }
}
