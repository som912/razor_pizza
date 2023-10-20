using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pizza.Data;
using razor_pizza.Models;

namespace razor_pizza.Pages
{
    public class ordersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<pizzaorder> p = new List<pizzaorder>();
        public ordersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            p = _context.pizzaorders.ToList();
        }
    }
}
