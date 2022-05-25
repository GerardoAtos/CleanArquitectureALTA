using Alta.DTOs;
using Alta.DTOs.DtoAbstraction;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IOutputPort<TDTO>
        where TDTO : DtoBase
    {
        Task Handle(TDTO tDto);
    }
}
