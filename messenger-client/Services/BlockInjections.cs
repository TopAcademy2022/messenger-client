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

			foreach (char symbol in this._ListProhibitedSymbol)
			{
				if (verifiedText.Contains(symbol))
				{
					rezult = false;
				}
			}

			return rezult;
		}
	}
}
