using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pizza.Data;
using razor_pizza.Models;

namespace razor_pizza.Pages
{
    [BindProperties(SupportsGet =true)]
    public class checkoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public string pizzaname {  get; set; }
        public float pizzaprice { get; set; }

        public string imagetitle {  get; set; }
        public checkoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(pizzaname))
            {
                pizzaname = "custom";
            }
            if (string.IsNullOrWhiteSpace(imagetitle))
            {
                imagetitle = "1";
            }
            pizzaorder p = new pizzaorder();
            p.pizzaname = pizzaname;
            p.baseprice = pizzaprice;
            _context.pizzaorders.Add(p);
            _context.SaveChanges();
        }
       

    }
}
