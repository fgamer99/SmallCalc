using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCalc
{
    enum ErrorCode
    {
        STATUS_OK,
        PARSER_CLEANUP_ERROR,
        PARSER_CLEANUP_TO_MANY_SYMBOLS,
        PARSER_CLEANUP_BRACKETS
    }
}
