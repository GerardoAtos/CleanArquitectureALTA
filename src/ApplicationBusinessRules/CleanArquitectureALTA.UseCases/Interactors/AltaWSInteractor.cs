using System.Threading.Tasks;
using Alta.DTOs.DtoAbstraction;
using Alta.UseCasesPorts.Interfaces;

namespace Alta.UseCases.Interactors
{
    public class AltaWSInteractor : IAltaWSInputPort
    {
        public Task Handle(DtoBase dto) => Task.CompletedTask;
    }
}
