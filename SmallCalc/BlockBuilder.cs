using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmallCalc
{
    class Block
    {
        public String data = "";
        public int token = -1;
        public bool solved = false;
        
        public Block(String data_in, int token_in, bool solved_in)
        {
            data = data_in;
            token = token_in;
            solved = solved_in;
        }
    }

    class BlockBuilder
    {
        private BlockBuilder()
        {}

        private static int tokens = 0;

        public static void resetTokens()
        {
            BlockBuilder.tokens = 0;
        }

        public static Block makeBlock(String data, bool solved)
        {
            return new Block(data, BlockBuilder.tokens++, solved);
        }

    }
}
