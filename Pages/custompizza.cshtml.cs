using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pizza.Models;

namespace razor_pizza.Pages
{
    public class custompizzaModel : PageModel
    {
        [BindProperty]
        public Models.pizzasModel pizza { get; set; }
        public float pizzaprice {  get; set; }  
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            pizzaprice = pizza.baseprice;
            if (pizza.tomatosouce) pizzaprice += 1;
            if (pizza.cheese) pizzaprice += 1;
            if (pizza.tuna) pizzaprice += 1;
            if (pizza.beef) pizzaprice += 1;
            if (pizza.hum) pizzaprice += 1;
            if (pizza.peperoni) pizzaprice += 10;
            if (pizza.pineapple) pizzaprice += 1;
            if (pizza.mushrom) pizzaprice += 1;

            return RedirectToPage("/checkout", new {pizza.pizzaname,pizzaprice});
        }
    }
}
