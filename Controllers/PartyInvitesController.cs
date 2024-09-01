using Microsoft.AspNetCore.Mvc;

namespace ProAspnetCore.Controllers
{
    public class PartyInvitesController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }

    }
}
