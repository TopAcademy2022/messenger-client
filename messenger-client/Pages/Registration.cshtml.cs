using messenger_client.Services;
using messenger_client.Services.Interfeces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace messenger_client.Pages
{
    public class RegistrationModel : PageModel
    {
        IBlockInjections blockInjections = new BlockInjections();

		public void OnGet(bool regRes)
		{
			if (regRes)
			{
				Response.Redirect("/Login");
			}
			
		}

		public void OnPost()
        {
			string? login = Request.Form["login"];
			string? password = Request.Form["password"];
			string? email = Request.Form["email"];

			if (blockInjections.CheckForProhibitedSymbol(login)&& 
				blockInjections.CheckForProhibitedSymbol(password)&& 
				blockInjections.CheckForProhibitedSymbol(email))
			{
				
				Response.Redirect("/Login");
			}
			else
			{
				Response.Redirect("/Registration");
			}
		}
    }
}
