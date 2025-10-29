using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetAll;
using Petfolio.Application.UseCases.Pets.Registrer;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
        {
            var useCase = new UpdatePetUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllPetsUseCase();

            var response = useCase.Execute();

            if(response.Pets.Any())
            {
                return Ok(response.Pets);
            }

            return NoContent();
        }

    }
}
