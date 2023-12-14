using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LastestProject.Data;

namespace LastestProject.Components
{
    public class Navbar:ViewComponent
    {
        private readonly LastestProjectDBContext _context;

        public Navbar(LastestProjectDBContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }
    }
}
