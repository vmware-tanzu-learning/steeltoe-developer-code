using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace FortuneTeller.UI.Pages
{
    public class RandomModel : PageModel
    {
        public string Message { get; private set; } = "Hello from FortuneTellerUI!";

        public RandomModel()
        {
        }

        public void OnGet()
        {
            HttpContext.Session.Set("MyFortune", Encoding.ASCII.GetBytes(Message));
        }
    }
}