using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MediatR;
using Personas.Negocio.DTOs;

namespace Personas.Negocio.Mediador.PersonaOperaciones.Comandos
{
    public class InsertarPersonaCommand : IRequest<PersonaDTO>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        
    }

    public class InsertarPersonaCommandValidator : AbstractValidator<InsertarPersonaCommand> 
    {
        public InsertarPersonaCommandValidator()
        {
            RuleFor(x => x.Nombre).NotNull().NotEmpty().NotEqual("").WithMessage("El campo Nombre es requerido");
            RuleFor(x => x.Apellido).NotNull().NotEqual("").WithMessage("El campo Apellido es requerido");
        }
    }
}
