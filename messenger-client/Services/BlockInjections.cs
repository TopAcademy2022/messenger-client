using messenger_client.Services.Interfeces;

namespace messenger_client.Services
{
    public class BlockInjections : IBlockInjections
    {
        char[] _ListProhibitedSymbol;

        public BlockInjections()
        {
            this._ListProhibitedSymbol = new char[] { '\'', '\"', '=', '*', '#', '|', '$','\\' };
        }
        public bool CheckForProhibitedSymbol(string str)
        {
            bool rezult = true;
            char[] temp = str.ToCharArray();
            foreach (char c in temp)
            {
                foreach (char b in this._ListProhibitedSymbol)
                {
                    if (b == c)
                    {
                        rezult = false;
                    }
                }
            }
            return rezult;
        }
    }
}
