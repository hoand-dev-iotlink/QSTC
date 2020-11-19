using System.Threading.Tasks;
//using IOT.Map.TestMap;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace IOT.Map.Samples
{
    [RemoteService]
    [Route("api/Map/sample")]
    public class SampleController : MapController
    {
        private readonly ISampleAppService _sampleAppService;

        public SampleController(ISampleAppService sampleAppService)
        {
            _sampleAppService = sampleAppService;
        }

        [HttpGet]
        public async Task<SampleDto> GetAsync()
        {
            return await _sampleAppService.GetAsync();
        }

        [HttpGet]
        [Route("authorized")]
        [Authorize]
        public async Task<SampleDto> GetAuthorizedAsync()
        {
            return await _sampleAppService.GetAsync();
        }

        [HttpGet("Test")]
        public async Task<string> GetTest()
        {
            return await _sampleAppService.GetTest();
        }
        //[HttpGet("informap")]
        //public async Task<InforMap> GetListById(string id)
        //{
        //    //try
        //    //{
        //        var obj = await _inforAppService.GetListById(id);
        //        return obj;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw ex;
        //    //}
        //}
        //[HttpPost("informap")]
        //public async Task<InforMap> Create([FromBody] InforMap param)
        //{
        ////    try
        ////    {
        //        var obj = await _inforAppService.Create(param);
        //        return obj;
        //    //}
        //    //catch (Exception ex)
        //    //{

        //    //    throw ex;
        //    //}
        //}
    }
}
