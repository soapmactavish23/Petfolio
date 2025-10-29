using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll
{
    public class GetAllPetsUseCase
    {

        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets =
                [
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Charlie",
                        Type = Communication.Enum.PetType.Dog,
                    }
                ],
            };
        }
    }
}
