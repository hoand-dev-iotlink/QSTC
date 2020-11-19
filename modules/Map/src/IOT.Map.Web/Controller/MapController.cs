using IOT.Map.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace IOT.Map.Web.Controller
{
    public abstract class MapController: AbpController
    {
        protected MapController()
        {
            //LocalizationSourceName = typeof(MapResource);
            ObjectMapperContext = typeof(MapWebModule);
        }
    }
}
