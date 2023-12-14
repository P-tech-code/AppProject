using Microsoft.AspNetCore.Mvc;
using LastestProject.Data;

namespace LastestProject.Components
{
    public class Imagebar:ViewComponent
    {
        private readonly LastestProjectDBContext _context;

        public Imagebar(LastestProjectDBContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Categories.ToList());
        }
    }
}
