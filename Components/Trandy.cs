using Microsoft.AspNetCore.Mvc;
using LastestProject.Data;

namespace LastestProject.Components
{
    public class Trandy:ViewComponent
    {
        private readonly LastestProjectDBContext _context;

        public Trandy(LastestProjectDBContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsTrandy==true).ToList());
        }
    }
}
