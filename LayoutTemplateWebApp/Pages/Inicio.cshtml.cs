using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LayoutTemplateWebApp.Pages
{
    public class InicioModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
        }
    }
}
