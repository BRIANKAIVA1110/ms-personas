using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Personas.Dominio.PersonasAgregados;
using Personas.Infraestructura;
using Personas.Negocio.DTOs;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Comandos
{
    public class InsertarPersonaHandler : IRequestHandler<InsertarPersonaCommand, PersonaDTO>
    {
        private readonly Infraestructura.IRepositoryBase<Persona> _repository;

        public InsertarPersonaHandler(IRepositoryBase<Persona> repository) 
        {
            this._repository = repository;
        }
        public Task<PersonaDTO> Handle(InsertarPersonaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
