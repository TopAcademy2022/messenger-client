using messenger_client.Services.Interfeces;
using static System.Net.Mime.MediaTypeNames;

namespace messenger_client.Services
{
    public class BlockInjections : IBlockInjections
    {
        private char[] _ListProhibitedSymbol;
        public BlockInjections()
        {
            this._ListProhibitedSymbol = new char[] { '\'', '\"', '=', '*', '#', '|', '$','\\' };
		}
        public bool CheckForProhibitedSymbol(string verifiedText)
        {
            bool rezult = true;
            char[] temp = verifiedText.ToCharArray();

            foreach (char symbolTemp in temp)
            {
                foreach (char symbol in this._ListProhibitedSymbol)
                {
                    if (symbol == symbolTemp)
                    {
                        rezult = false;
                    }
                }
            }

            return rezult;
        }
    }
}
