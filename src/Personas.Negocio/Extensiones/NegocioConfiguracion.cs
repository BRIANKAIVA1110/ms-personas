using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Reflection;

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
    }
}
