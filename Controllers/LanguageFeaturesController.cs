using Microsoft.AspNetCore.Mvc;

namespace ProAspnetCore.Controllers
{
    public class LanguageFeaturesController : Controller
    {

        private readonly ILogger<LanguageFeaturesController> _logger;

        public LanguageFeaturesController(ILogger<LanguageFeaturesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new string[] {"C#","Language","Features"});
        }
    }
}
