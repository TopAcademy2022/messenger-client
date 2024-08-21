using messenger_client.Services.Interfeces;

namespace messenger_client.Services
{
	public class BlockInjections : IBlockInjections
	{
		private char[] _ListProhibitedSymbol;

		public BlockInjections()
		{
			this._ListProhibitedSymbol = new char[] { '\'', '\"', '=', '*', '#', '|', '$', '\\' };
		}

		public bool CheckProhibitedSymbols(string verifiedText)
		{
			bool rezult = true;

			if (verifiedText.Any(symbol => this._ListProhibitedSymbol.Contains(symbol)))
			{
				rezult = false;
			}

			return rezult;
		}
	}
}
