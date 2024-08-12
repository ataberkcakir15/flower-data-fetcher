using Business.Abstract;
using Core.Common.Concrete;
using Core.Constants;
using Core.Models.Response;
using DataAccess.Repositories.Abstract;
using System.Net;

namespace Business.Concrete
{
    public class FlowerService : IFlowerService
    {
        private readonly IFlowerRepository _flowerRepository;

        public FlowerService(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        public async Task<ServiceResult<GetFlowersInformationResponseModel>> GetFlowerInformationAsync()
        {
            try
            {
                var response = await _flowerRepository.GetFlowerInformationAsync();

                if (response == null)
                {
                    return new ServiceResult<GetFlowersInformationResponseModel>
                    {
                        HttpStatusCode = HttpStatusCode.NoContent
                    };
                }
                else
                {
                    return new ServiceResult<GetFlowersInformationResponseModel>
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        UserMessage = ResponseMessagesConstant.SUCCESS,
                        InternalMessage = ResponseMessagesConstant.SUCCESS,
                        Data = response
                    };
                }
            }
            catch (Exception exception)
            {
                return new ServiceResult<GetFlowersInformationResponseModel>
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    UserMessage = ResponseMessagesConstant.EXCEPTION,
                    InternalMessage = $" Hata mesajı {exception.Message} {exception.InnerException}",
                };
            }
        }
    }
}
