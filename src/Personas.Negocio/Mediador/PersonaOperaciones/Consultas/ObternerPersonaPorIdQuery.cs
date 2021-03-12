using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Personas.Negocio.DTOs;
using FluentValidation;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Consultas
{
    public class ObternerPersonaPorIdQuery: IRequest<PersonaDTO>
    {
        public int Id { get; set; }
    }

    public class ObternerPersonaPorIdValidator: AbstractValidator<ObternerPersonaPorIdQuery>
    {
        public ObternerPersonaPorIdValidator() 
        {
            RuleFor(x => x.Id > 0).NotNull().WithMessage("Requerido");
        }
    }
}
