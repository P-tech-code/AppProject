using Microsoft.AspNetCore.Mvc;
using LastestProject.Data;

namespace LastestProject.Components
{
    public class JustArrived:ViewComponent
    {
        private readonly LastestProjectDBContext _context;

        public JustArrived(LastestProjectDBContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsArrived==true).ToList());
        }
    }
}
