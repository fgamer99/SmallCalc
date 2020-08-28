using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCalc
{
    class ErrorHandler
    {
        public static String getErrorMessage(ErrorCode errorCode)
        {
            switch(errorCode)
            {
                case ErrorCode.PARSER_CLEANUP_BRACKETS:
                    return "ERROR: Some bracket is missing or to much";
                case ErrorCode.PARSER_CLEANUP_TO_MANY_SYMBOLS:
                    return "ERROR: There are to many symbols";
            }

            return "UNDEFINED ERROR";
        }
    }
}
