using System;
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
            //stringToParse = cleanUpCode(stringToParse);
            while(hasLowerBracket(stringToParse))
            {
                String lowestBracket = getLowestBracket(stringToParse);
                String lowestBracketSolution = calcString(lowestBracket);
                if(lowestBracketSolution=="Error")
                {
                    return "Error";
                }
                stringToParse = setLowestBracket(stringToParse, lowestBracketSolution);
            }
            stringToParse = calcString(stringToParse);
            if (stringToParse == "Error")
            {
                return "Error";
            }
            return stringToParse;
        }

       private static bool hasLowerBracket(String stringToParse)
        {
            for(int i=0;i<stringToParse.Length;i++)
            {
                if(stringToParse.ElementAt(i)=='(')
                {
                    return true;
                }
            }
            return false;
        }

        private static String getLowestBracket(String stringToParse)
        {
            String lowestBracket = "";
            for(int i=0;i<stringToParse.Length;i++)
            {
                if(stringToParse.ElementAt(i)=='(')
                {
                    int startIndex = i;
                    for(int j=startIndex+1;j<stringToParse.Length;j++)
                    {
                        if(stringToParse.ElementAt(j)=='(')
                        {
                            lowestBracket = "";
                            continue;
                        }
                        if (stringToParse.ElementAt(j) == ')')
                        {
                            break;
                        }
                        lowestBracket += stringToParse.ElementAt(j);
                    }
                    break;
                }
            }
            return lowestBracket;
        }

        private static String calcString(String stringToCalc)
        {
            String leftSideString = "";
            String rightSideString = "";
            double leftSide = 0;
            double rightSide = 0;

            //loop for * and /
            for(int i=0;i<stringToCalc.Length;i++)
            {
                leftSideString = "";
                rightSideString = "";
                if(stringToCalc.ElementAt(i)=='*' || stringToCalc.ElementAt(i) == '/')
                {
                    //search left side
                    for(int j=i-1;j>=0;j--)
                    {
                        if(stringToCalc.ElementAt(j) == '+' || stringToCalc.ElementAt(j) == '-')
                        {
                            break;
                        }
                        String tmp = "";
                        char c = stringToCalc.ElementAt(j);
                        tmp += c;
                        leftSideString=leftSideString.Insert(0, tmp);
                    }
                    //search right side
                    for (int j = i + 1; j < stringToCalc.Length; j++)
                    {
                        if (stringToCalc.ElementAt(j) == '+' || stringToCalc.ElementAt(j) == '-'
                            || stringToCalc.ElementAt(j) == '*' || stringToCalc.ElementAt(j) == '/')
                        {
                            break;
                        }
                        rightSideString += stringToCalc.ElementAt(j);
                    }
                    //calculate new string for right and left side
                    try
                    {
                        leftSide = Double.Parse(leftSideString);
                        rightSide = Double.Parse(rightSideString);
                    }
                    catch (Exception e)
                    {
                        return "Error";
                    }
                    String sol = "";
                    if(stringToCalc.ElementAt(i)=='*')
                    {
                        sol = Convert.ToString(leftSide * rightSide);
                    }
                    else if (stringToCalc.ElementAt(i) == '/')
                    {
                        sol = Convert.ToString(leftSide / rightSide);
                    }
                    //replace sol in string
                    String toReplace = leftSideString;
                    if (stringToCalc.ElementAt(i) == '*')
                    {
                        toReplace += '*';
                    }
                    else if (stringToCalc.ElementAt(i) == '/')
                    {
                        toReplace += '/';
                    }
                    toReplace += rightSideString;

                    stringToCalc=stringToCalc.Replace(toReplace, sol);
                    //search again from beginning
                    i = -1;
                }
            }
            //loop for + and -
            for (int i = 0; i < stringToCalc.Length; i++)
            {
                leftSideString = "";
                rightSideString = "";
                if (stringToCalc.ElementAt(i) == '+' || stringToCalc.ElementAt(i) == '-')
                {
                    //search left side
                    for (int j = i - 1; j >= 0; j--)
                    {
                        String tmp = "";
                        char c = stringToCalc.ElementAt(j);
                        tmp += c;
                        leftSideString=leftSideString.Insert(0, tmp);
                    }
                    //search right side
                    for (int j = i + 1; j < stringToCalc.Length; j++)
                    {
                        if (stringToCalc.ElementAt(j) == '+' || stringToCalc.ElementAt(j) == '-')
                        {
                            break;
                        }
                        rightSideString += stringToCalc.ElementAt(j);
                    }
                    //calculate new string for right and left side
                    try
                    {
                        leftSide = Double.Parse(leftSideString);
                        rightSide = Double.Parse(rightSideString);
                    }
                    catch(Exception e)
                    {
                        return "Error";
                    }
                    
                    String sol = "";
                    if (stringToCalc.ElementAt(i) == '+')
                    {
                        sol = Convert.ToString(leftSide + rightSide);
                    }
                    else if (stringToCalc.ElementAt(i) == '-')
                    {
                        sol = Convert.ToString(leftSide - rightSide);
                    }
                    //replace sol in string
                    String toReplace = leftSideString;
                    if (stringToCalc.ElementAt(i) == '+')
                    {
                        toReplace += '+';
                    }
                    else if (stringToCalc.ElementAt(i) == '-')
                    {
                        toReplace += '-';
                    }
                    toReplace += rightSideString;

                    stringToCalc=stringToCalc.Replace(toReplace, sol);
                    //search again from beginning
                    i = -1;
                }
            }
            //
            return stringToCalc;
        }

        private static String setLowestBracket(String mainString, String lowestBracket)
        {
            String bracketToReplace = "";

            for(int i=0;i<mainString.Length;i++)
            {
                if(mainString.ElementAt(i)=='(')
                {
                    bracketToReplace = "(";
                    continue;
                }
                if (mainString.ElementAt(i) == ')')
                {
                    bracketToReplace += ")";
                    break;
                }
                bracketToReplace += mainString.ElementAt(i);
            }

            return mainString.Replace(bracketToReplace,lowestBracket);
        }

        private static String cleanUpCode(String stringToClean)
        {
            //clean spaces
            stringToClean = stringToClean.Replace(" ", "");
            //check if any operaor is in front of a bracket, if not, replace it with *
            for(int i=0;i<stringToClean.Length;i++)
            {
                if(stringToClean.ElementAt(i)=='('&&i!=0)
                {
                    if(stringToClean.ElementAt(-i)!='+'&& stringToClean.ElementAt(-i) != '-'&& 
                        stringToClean.ElementAt(-i) != '*' && stringToClean.ElementAt(-i) != '/')
                    {
                        stringToClean=stringToClean.Insert(i, "*");
                    }
                }
            }
            return stringToClean;
        }
    }
}
