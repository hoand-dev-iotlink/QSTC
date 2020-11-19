using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace IOT.Map.Web.Controller
{
    public class HomeController : MapController
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
