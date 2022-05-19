using System.Threading.Tasks;
using Alta.DTOs.DtoAbstraction;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IAltaWSInputPort
    {
        public Task Handle(DtoBase dtoB);
    }
}