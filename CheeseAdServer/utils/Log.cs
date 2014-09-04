using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheeseAdServer.utils
{
    class Log
    {
        public static void d(String tag, String msg) {
            Console.WriteLine(tag + ":" + msg);
        }
    }
}
