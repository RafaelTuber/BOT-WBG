using System;
using System.Collections.Generic;
using System.Text;

namespace BOT_WBG
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
