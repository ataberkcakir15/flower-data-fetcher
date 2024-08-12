using Core.Common.Concrete;
using Core.Models.Response;

namespace Business.Abstract
{
    public interface IFlowerService
    {
        Task<ServiceResult<GetFlowersInformationResponseModel>> GetFlowerInformationAsync();
    }
}
