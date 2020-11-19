using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace IOT.Map.Samples
{
    public class SampleAppService : MapAppService, ISampleAppService
    {
        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
        public Task<string> GetTest()
        {
            return Task.FromResult("True");
        }
    }
}