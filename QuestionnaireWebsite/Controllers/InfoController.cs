using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireWebsite.Controllers
{
    public class InfoController : Controller
    {
        [Route("Info/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Info/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}