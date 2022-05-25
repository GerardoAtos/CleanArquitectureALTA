using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactors
{
    public class LoginInteractor : ILoginInputPort
    {
        private readonly ILoginOutputPort _loginOutputPort;
        private readonly IUserLoginRepository _loginRepository;

        public LoginInteractor(
            ILoginOutputPort loginOutputPort,
            IUserLoginRepository loginRepository
        ) => (_loginOutputPort, _loginRepository) = (loginOutputPort, loginRepository);

        public async Task Handle(UserDTO user)
        {
            bool exists = await _loginRepository.ExistsUserAsync(user.Username, user.Password);

            //Returns user dto and if it exists
            await _loginOutputPort.Handle(user, exists);
        }
    }
}
