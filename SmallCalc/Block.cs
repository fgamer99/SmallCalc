using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SmallCalc
{
    class Block
    {
        private static char tokenSymbol = ':';
        private static int tokens = 0;
        public int token = -1;
        public String data = "";
        public bool solved = false;
        private Block(String data_in, int token_in)
        {
            data = data_in;
            token = token_in;
        }

        public static Block makeBlock(String data)
        {
            return new Block(data, Block.tokens++);
        }

        public static char getTokenSymbol()
        {
            return Block.tokenSymbol;
        }
    }
}
