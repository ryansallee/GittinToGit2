using System;
using System.Collections.Generic;
using System.Text;

namespace GittinToGit
{
    public static class FunClass
    {
        public static string FunString(this string notFunString)
        {
            return notFunString + " NOW IT's FUN!";
        }
    }
}
