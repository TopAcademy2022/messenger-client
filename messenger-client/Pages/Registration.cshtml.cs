using messenger_client.Services;
using messenger_client.Services.Interfeces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace messenger_client.Pages
{
	public class RegistrationModel : PageModel
	{
		private IBlockInjections blockInjections = new BlockInjections();
		public string IncorrectDataMessage { get; set; }

		public void OnGet(bool regRes)
		{
			if (regRes)
			{
				Response.Redirect("/Login");
			}
		}

		public IActionResult OnPostRegistration([FromBody] RegistrationData data)
		{
			IncorrectDataMessage = String.Empty;

			string? login = data.Login;
			string? password = data.Password;
			string? email = data.Email;

			if (login != String.Empty && password != String.Empty && email != String.Empty)
			{
				if (blockInjections.CheckForProhibitedSymbol(login) &&
				blockInjections.CheckForProhibitedSymbol(password) &&
				blockInjections.CheckForProhibitedSymbol(email))
				{
					if (true)
					{
						IncorrectDataMessage = "This login already exists";
					}
					else if (true)
					{
						IncorrectDataMessage = "This email already exists";
					}
					else
					{
						IncorrectDataMessage = "You are registered";
					}
				}
				else
				{
					IncorrectDataMessage = "Invalid characters entered (\\\' , \\\" , = , * , # , | , $ , \\ )";
				}
			}
			return Content($"<script id=\"message\">alert(\"{IncorrectDataMessage}\")</script>");
		}

		public class RegistrationData
		{
			public string? Login { get; set; }

			public string? Password { get; set; }

			public string? Email { get; set; }
		}
	}
}
