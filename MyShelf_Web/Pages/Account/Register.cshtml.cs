using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShelf_Web.Model;

namespace MyShelf_Web.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public Registration NewUser { get; set; } = new Registration();
        public void OnGet()
        {
            NewUser.FirstName = "John";
        }
        public void OnPost()
        {

        }
    }
}
