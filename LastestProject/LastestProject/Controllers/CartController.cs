using Microsoft.AspNetCore.Mvc;
using LastestProject.Data;
using LastestProject.Infrastructure;
using LastestProject.Models;

namespace LastestProject.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        private readonly LastestProjectDBContext _context;

        public CartController(LastestProjectDBContext context)
        {
            _context = context;
        }
        public IActionResult AddToCart(int productId)
        {
            Product? product = _context.Products
.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", Cart);
            }
                return View("Cart", Cart);
        
        }
        public IActionResult RemoveFromCart(int productId)
        {
            Product? product = _context.Products
.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart");
                Cart.RemoveLine(product);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);

        }
        public IActionResult UpdateCart(int productId)
        {
            Product? product = _context.Products
.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, -1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);

        }
        public IActionResult Index()
        {
            return View("Cart", HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
