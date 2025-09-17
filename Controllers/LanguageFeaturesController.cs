using Microsoft.AspNetCore.Mvc;

namespace ProAspnetCore.Controllers
{
    public class LanguageFeaturesController(ILogger<LanguageFeaturesController> logger) : Controller
    {

        private readonly ILogger<LanguageFeaturesController> _logger = logger;

        public IActionResult Index()
        {
            return View(new string[] {"C#","Language","Features"});
        }
    }
}
