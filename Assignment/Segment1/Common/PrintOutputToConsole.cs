using System;

namespace Assignmet.Common
{
    class PrintOutputToConsole : IUpdateConsole
    {
        public void UpdateConsle(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }

        public void UpdateConsle(string textToPrint, int intput, string textToPrint2)
        {
            Console.WriteLine(textToPrint, intput, textToPrint2);
        }
    }
}
