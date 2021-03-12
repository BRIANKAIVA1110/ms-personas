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

        public ObternerPersonaPorIdQuery(int Id)
        {
            this.Id = Id;
        }
    }

    public class ObternerPersonaPorIdValidator: AbstractValidator<ObternerPersonaPorIdQuery>
    {
        public ObternerPersonaPorIdValidator() 
        {
            RuleFor(x => x.Id).NotNull().WithMessage("El campo Id es requerido");
        }
    }
}
