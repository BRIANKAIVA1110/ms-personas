using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Personas.Negocio.DTOs;
using Personas.Negocio.Mediador.PersonaOperaciones.Comandos;
using Personas.Negocio.Mediador.PersonaOperaciones.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Personas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonasController(IMediator mediator)
        {
            this._mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Obtiene registros de personas 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PersonaDTO>))]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _mediator.Send(new ObtenerPersonasQuery());

            return Ok(result);
        }

        /// <summary>
        /// Obtiene registro de persona por Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAsync([FromRoute] int Id)
        {

            var result = await _mediator.Send(new ObternerPersonaPorIdQuery(Id));

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostAsync([FromBody] InsertarPersonaCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else {
                return Ok();
            }
        }

    }
}
