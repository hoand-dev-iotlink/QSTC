using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace IOT.Map.InforMaps
{
    [RemoteService]
    [Route("api/Map/informap")]
    public class InforMapController : MapController
    {
        private readonly IInforMapService _inforMapService;

        public InforMapController(IInforMapService inforMapService)
        {
            _inforMapService = inforMapService;
        }
        [HttpGet]
        public async Task<InforMapDto> GetById(string id)
        {
            return await _inforMapService.GetAsync(Guid.Parse(id));
        }
    }
}
