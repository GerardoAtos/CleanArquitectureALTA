using Alta.DTOs;
using Alta.Presenters.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Alta.Presenters.Presenters
{
    public class LoginPresenter : ILoginOutputPort, IPresenter<ClaimsPrincipal>
    {
        public ClaimsPrincipal? Content { get; private set; }
        public bool UserExistance { get; private set; }

        public async Task Handle(UserDTO user, bool userExistance)
        {
            UserExistance = userExistance;

            var userClaims = new List<Claim>(){
                    new Claim(ClaimTypes.Name, user.username)
                };

            var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");

            Content = new ClaimsPrincipal(new[] { grandmaIdentity });

            await Task.CompletedTask;
        }
    }
}
