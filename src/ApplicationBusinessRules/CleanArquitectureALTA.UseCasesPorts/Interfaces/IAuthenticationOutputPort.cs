using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IAuthenticationOutputPort
    {
        public Task Handle();
    }
}
