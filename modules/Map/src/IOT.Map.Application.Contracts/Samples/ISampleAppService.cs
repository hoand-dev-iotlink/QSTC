using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace IOT.Map.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
        Task<string> GetTest();
    }
}
