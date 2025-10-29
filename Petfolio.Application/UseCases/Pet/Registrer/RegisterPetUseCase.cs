using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pet.Registrer
{
    public class RegisterPetUseCase
    {

        public ResponseRegisterPetJson Execute(RequestRegisterPetJson request)
        {
            return new ResponseRegisterPetJson
            {
                Id = 7,
                Name = request.Name,
            };
        }

    }
}
