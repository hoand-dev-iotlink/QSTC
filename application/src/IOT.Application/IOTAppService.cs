using System;
using System.Collections.Generic;
using System.Text;
using IOT.Localization;
using Volo.Abp.Application.Services;

namespace IOT
{
    /* Inherit your application services from this class.
     */
    public abstract class IOTAppService : ApplicationService
    {
        protected IOTAppService()
        {
            LocalizationResource = typeof(IOTResource);
        }
    }
}
