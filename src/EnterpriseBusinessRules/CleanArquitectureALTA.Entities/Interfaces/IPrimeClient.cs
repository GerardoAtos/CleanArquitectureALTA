using Alta.DTOs.DtoAbstraction;
using Alta.DTOs.HttpDTOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces
{
    public interface IPrimeClient
    {
        Task<TransactionResult> SendMessage(string uri, DtoBase dto);

        Task<TransactionResult> Authenticate();
    }
}
