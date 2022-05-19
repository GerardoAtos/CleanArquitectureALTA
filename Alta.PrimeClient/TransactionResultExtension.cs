using System.Net.Http;
using System.Threading.Tasks;
using Alta.DTOs.DtoAbstraction;
using Alta.DTOs.HttpDTOs;

namespace Alta.PrimeClient
{
    public static class TransactionResultExtension
    {
        public static async Task<TransactionResult> ToResult(this HttpResponseMessage result, DtoBase dto)
        {
            return new TransactionResult { CODE = (int)result.StatusCode, DATA = dto, MESSAGE = await result.Content.ReadAsStringAsync() };
        }
        public static async Task<TransactionResult> ToResult(this HttpResponseMessage result)
        {
            return new TransactionResult { CODE = (int)result.StatusCode, MESSAGE = await result.Content.ReadAsStringAsync() };
        }
    }
}
