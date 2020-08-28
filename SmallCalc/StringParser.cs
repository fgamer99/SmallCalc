using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallCalc
{
    class StringParser
    {
        public static String parseStringToSolution(String stringToParse)
        {
            ErrorCode status = ErrorCode.STATUS_OK;

            //cleanup string
            if((status=cleanUpCode(ref stringToParse))!=ErrorCode.STATUS_OK)
            {
                return ErrorHandler.getErrorMessage(status);
            }

            //make blocks
            List<Block> blockList = new List<Block>();
            if ((status = makeBlocks(stringToParse,ref blockList)) != ErrorCode.STATUS_OK)
            {
                return ErrorHandler.getErrorMessage(status);
            }

            //calculate blocks
            calculateAllBlocks(ref stringToParse, ref blockList);

            return stringToParse;
        }

        private static ErrorCode calculateAllBlocks(ref String solution, ref List<Block> tokenList)
        {
            while(tokenList.Count>1)
            {
                for(int i=0;i<tokenList.Count;i++)
                {
                    if(checkForToken(tokenList.ElementAt(i).data) || tokenList.ElementAt(i).solved )
                    {
                        continue;
                    }
                    else
                    {
                        tokenList[i] = calculateBlock(tokenList.ElementAt(i));
                        replaceTokens(ref tokenList, tokenList[i]);
                    }
                }
            }
            //one left
            solution = calculateBlock(tokenList[0]).data;

            return ErrorCode.STATUS_OK;
        }

        private static void replaceTokens(ref List<Block> tokenList, Block tokenToReplace)
        {
            for(int i=0;i<tokenList.Count;i++)
            {
                String token = ""+ Block.getTokenSymbol()+tokenToReplace.token+Block.getTokenSymbol();

                tokenList[i].data = tokenList[i].data.Replace(token, tokenToReplace.data);
            }
            tokenList.Remove(tokenToReplace);
        }

        private static Block calculateBlock(Block block)
        {
            //solve for * and /
            block = solveForDots(block);
            //solve for + and -
            block = solveForLines(block);
            //final
            block.solved = true;
            return block;
        }

        private static Block solveForDots(Block block)
        {
            //solve for * and / 
            for (int i = 0; i < block.data.Length; i++)
            {
                if (block.data.ElementAt(i) == '*' || block.data.ElementAt(i) == '/')
                {
                    int leftSideStart = -1;
                    int rightSideEnd = -1;
                    String leftSideString = "";
                    String rightSideString = "";

                    //left side
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            leftSideStart = 0;
                            break;
                        }
                        if (block.data.ElementAt(j) == '*' || block.data.ElementAt(j) == '/' ||
                           block.data.ElementAt(j) == '+' || block.data.ElementAt(j) == '-')
                        {
                            leftSideStart = j + 1;
                            break;
                        }
                    }

                    //right side
                    for (int j = i + 1; j < block.data.Length; j++)
                    {
                        if (block.data.ElementAt(j) == '*' || block.data.ElementAt(j) == '/' ||
                           block.data.ElementAt(j) == '+' || block.data.ElementAt(j) == '-')
                        {
                            rightSideEnd = j - 1;
                            break;
                        }
                        else if (j == block.data.Length - 1)
                        {
                            rightSideEnd = j;
                            break;
                        }
                    }
                    //calculate strings and solution
                    leftSideString = block.data.Substring(leftSideStart, i - leftSideStart);
                    rightSideString = block.data.Substring(i + 1, rightSideEnd - i);

                    double left = Double.Parse(leftSideString);
                    double right = Double.Parse(rightSideString);
                    String solution = "";

                    if (block.data.ElementAt(i) == '*')
                    {
                        solution = Convert.ToString(left * right);
                    }
                    else if (block.data.ElementAt(i) == '/')
                    {
                        solution = Convert.ToString(left / right);
                    }
                    //replace
                    block.data = block.data.Replace(leftSideString + block.data.ElementAt(i) + rightSideString, solution);
                }
            }
            return block;
        }

        private static Block solveForLines(Block block)
        {
            //solve for + and -
            for (int i = 0; i < block.data.Length; i++)
            {
                if (block.data.ElementAt(i) == '+' || block.data.ElementAt(i) == '-')
                {
                    int leftSideStart = -1;
                    int rightSideEnd = -1;
                    String leftSideString = "";
                    String rightSideString = "";
                    
                    //skip if - is in front
                    if(i==0)
                    {
                        continue;
                    }

                    //left side
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            leftSideStart = 0;
                            break;
                        }
                        if (block.data.ElementAt(j) == '+' || block.data.ElementAt(j) == '-')
                        {
                            leftSideStart = j + 1;
                            break;
                        }
                    }

                    //right side
                    for (int j = i + 1; j < block.data.Length; j++)
                    {
                        if (block.data.ElementAt(j) == '+' || block.data.ElementAt(j) == '-')
                        {
                            rightSideEnd = j - 1;
                            break;
                        }
                        else if(j==block.data.Length-1)
                        {
                            rightSideEnd = j;
                            break;
                        }
                    }
                    //calculate strings and solution
                    leftSideString = block.data.Substring(leftSideStart, i - leftSideStart);
                    rightSideString = block.data.Substring(i+1, rightSideEnd - i);

                    double left = Double.Parse(leftSideString);
                    double right = Double.Parse(rightSideString);
                    String solution = "";

                    if (block.data.ElementAt(i) == '+')
                    {
                        solution = Convert.ToString(left + right);
                    }
                    else if (block.data.ElementAt(i) == '-')
                    {
                        solution = Convert.ToString(left - right);
                    }
                    //replace
                    block.data = block.data.Replace(leftSideString + block.data.ElementAt(i) + rightSideString, solution);
                    i = -1;
                    continue;
                }
            }
            return block;
        }

        private static bool checkForToken(String stringToParse)
        {
            for(int i=0;i<stringToParse.Length;i++)
            {
                if(stringToParse.ElementAt(i)==Block.getTokenSymbol())
                {
                    return true;
                }

            }

            return false;
        }

        private static ErrorCode makeBlocks(String stringToParse, ref List<Block> tokenList)
        {
            int tokenStart = -1;
            int tokenEnd = -1;

            //check for brackets and tokenize them
            for (int i=0;i<stringToParse.Length;i++)
            {
                if(stringToParse.ElementAt(i)=='(')
                {
                    tokenStart = i;
                    for(int j=i+1;i<stringToParse.Length;j++)
                    {
                        if (stringToParse.ElementAt(j) == '(')
                        {
                            tokenStart = j;
                        }
                        else if (stringToParse.ElementAt(j) == ')')
                        {
                            tokenEnd = j;
                            int tokenLenght = tokenEnd - tokenStart + 1;
                            Block block = Block.makeBlock(stringToParse.Substring(tokenStart+1, tokenLenght-2));//only the value inside the brackets
                            stringToParse=stringToParse.Remove(tokenStart, tokenLenght);
                            stringToParse=stringToParse.Insert(tokenStart, ""+Block.getTokenSymbol() + block.token + Block.getTokenSymbol());
                            tokenList.Add(block);
                            i = -1;
                            break;
                        }
                    }
                }
            }
            
            tokenList.Add(Block.makeBlock(stringToParse));
            return ErrorCode.STATUS_OK;
        }

        private static ErrorCode cleanUpCode(ref String stringToClean)
        {
            //clean spaces
            stringToClean = stringToClean.Replace(" ", "");

            //check if any operaor is in front of a bracket, if not, replace it with *
            for(int i=0;i<stringToClean.Length;i++)
            {
                if(stringToClean.ElementAt(i)=='('&&i!=0)
                {
                    if(stringToClean.ElementAt(i-1)!='+'&& stringToClean.ElementAt(i-1) != '-'&& 
                        stringToClean.ElementAt(i-1) != '*' && stringToClean.ElementAt(i-1) != '/')
                    {
                        stringToClean=stringToClean.Insert(i, "*");
                    }
                }
            }

            //check if every bracket is closed
            int br = 0;
            for (int i = 0; i < stringToClean.Length; i++)
            {
                if (stringToClean.ElementAt(i) == '(')
                {
                    br++;
                }
                else if (stringToClean.ElementAt(i) == ')')
                {
                    br--;
                }
            }
            if(br!=0)
            {
                return ErrorCode.PARSER_CLEANUP_BRACKETS;
            }

            //check for double opperators 
            for (int i = 0; i < stringToClean.Length; i++)
            {
                if (stringToClean.ElementAt(i) == '+' || stringToClean.ElementAt(i) == '-' || 
                    stringToClean.ElementAt(i) == '*' || stringToClean.ElementAt(i) == '/' )
                {
                    if (stringToClean.ElementAt(1+i) == '+' && stringToClean.ElementAt(1+i) == '-' &&
                        stringToClean.ElementAt(1+i) == '*' && stringToClean.ElementAt(1+i) == '/')
                    {
                        return ErrorCode.PARSER_CLEANUP_TO_MANY_SYMBOLS;
                    }
                }
            }
            
            return ErrorCode.STATUS_OK;
        }
    }
}
