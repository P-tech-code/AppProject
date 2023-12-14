using LastestProject.Data;
using LastestProject.Infrastructure;
using LastestProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LastestProject.Components
{
    public class CardWidget:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}

