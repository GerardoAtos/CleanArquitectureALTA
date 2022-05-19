using Alta.DTOs;
using Alta.Presenters.Presenters;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Alta.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILoginOutputPort _loginOutputPort;
        private readonly ILoginInputPort _loginInputPort;

        public LoginController(ILoginOutputPort loginOutputPort, ILoginInputPort loginInputPort) => 
            (_loginOutputPort, _loginInputPort) = (loginOutputPort, loginInputPort);

        /// <summary>
        /// HTTP POST method using for user authentication
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]UserDTO user)
        {
            //Handle user and check if it exists and credentials are correct.
            await this._loginInputPort.Handle(user);
            LoginPresenter presenter = ((LoginPresenter)_loginOutputPort);

            //if non-valid return Unauthorized.
            if(!presenter.UserExistance) return Unauthorized();

            await HttpContext.SignInAsync(presenter.Content);
            return Ok();
        }



        //Revisar si es necesario
        [HttpGet("/username/{username}/password/{password}")]
        public async Task<IActionResult> LoginByUsernameAndPassword(string username, string password)
        {
            return null;
        }

        [Authorize]
        [HttpGet("/CheckLogin")]
        public async Task<IActionResult> CheckLogin()
        {
            return Ok();
        }
    }
}
