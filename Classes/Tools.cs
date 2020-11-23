using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HMSV2.Classes
{
    public class Tools
    {
        public static string trnmodifer(string trn)
        {
            if (!trn.Contains("-"))
            {
                trn = Regex.Replace(trn, ".{3}", "$0-");
                if (trn.EndsWith("-"))
                    trn = trn.Remove(trn.Length - 1, 1);
            }
            return trn;
        }
    }
}
