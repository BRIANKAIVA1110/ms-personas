using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Reflection;
using FluentValidation.AspNetCore;

namespace Personas.Negocio.Extensiones
{
    public static class NegocioConfiguracion
    {
        public static IServiceCollection AddNegocioConfiguracion(this IServiceCollection services)
        {
            /*
             * Persona.Negocio <-Assembly
             */
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

        public static IMvcBuilder AddNegocioFluentValidation(this IMvcBuilder builder) 
        {
            builder.AddFluentValidation(config=> {
                config.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

            return builder;
        }
    }
}
