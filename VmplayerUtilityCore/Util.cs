using System;
using System.Collections.Generic;
using System.Linq;

namespace VmplayerUtilityCore
{
    internal static class Util
    {
        public static Dictionary<string, string> ReadConfig(IEnumerable<string> configfile)
        {
            Dictionary<string, string> keyValue =
                (from line in configfile
                 select line.Split(new char[] { '=' }, 2))
                 .ToDictionary(l => l[0].Trim(), l => l[1].Trim(' ', '"'));
            return keyValue;
        }
    }
}
