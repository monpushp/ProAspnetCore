using Microsoft.AspNetCore.Mvc;
using ProAspnetCore.Models;

namespace ProAspnetCore.Controllers
{
    public class PartyInvitesController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            return View();
        }

    }
}
