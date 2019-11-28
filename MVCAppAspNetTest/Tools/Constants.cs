using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppAspNetTest.Tools
{
    public class Constants
    {
        private static int _logTryes = 3;

        public static int LogTryes { get => _logTryes; }
    }
}
