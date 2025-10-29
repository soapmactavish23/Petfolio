using Petfolio.Communication.Responses;
using System.Reflection.Metadata.Ecma335;

namespace Petfolio.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Pipoca",
                Type = Communication.Enum.PetType.Cat,
                Birthday = new DateTime(year: 2023, month: 01, day: 01),
            };
        }
    }
}
