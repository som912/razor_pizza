using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pizza.Models;

namespace razor_pizza.Pages
{
    public class pizzaModel : PageModel
    {
        public List<pizzasModel> fakedb = new List<pizzasModel>()
        {
            new pizzasModel(){
                imagetitle="2",
                pizzaname="ff",
                baseprice=5,
                tomatosouce=true,
                cheese=true,
                finalprice=4
},  new pizzasModel(){
                imagetitle="2",
                pizzaname="ff",
                baseprice=5,
                tomatosouce=true,
                cheese=true,
                finalprice=4
},  new pizzasModel(){
                imagetitle="2",
                pizzaname="ff",
                baseprice=5,
                tomatosouce=true,
                cheese=true,
                finalprice=4
},
        };
        public void OnGet()
        {
        }
    }
}
