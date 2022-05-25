using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Presenters.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System.Threading.Tasks;

namespace Alta.Presenters.Presenters
{
    public class CreateLineInventoryPresenter : ICreateLineInventoryOutputPort, IPresenter<TransactionResult>
    {
        public TransactionResult Content { get; private set; }

        public async Task Handle(CreateLineInventoryDTO createLineInventoryDTO) => await Task.CompletedTask;
    }
}
