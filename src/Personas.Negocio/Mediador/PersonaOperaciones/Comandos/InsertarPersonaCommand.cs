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
        public int Edad { get; set; }

        
    }

    public class InsertarPersonaCommandValidator : AbstractValidator<InsertarPersonaCommand> 
    {
        public InsertarPersonaCommandValidator()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEmpty()
                .WithMessage("El campo Nombre es requerido")
                .WithErrorCode("ERROR:1234");
            RuleFor(x => x.Apellido)
                .NotNull()
                .NotEmpty().WithErrorCode("ERROR:1235pepe")
                .WithMessage("El campo Apellido es requerido").WithErrorCode("ERROR:1235");
            RuleFor(x => x.Edad)
                .Must(x => x <= 120)
                .NotNull()
                .WithMessage("El dato ingresado no es valido.")
                .WithErrorCode("ERROR:1236");
        }
    }
}
