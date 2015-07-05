using System;

namespace Assignmet.Common
{
    class PrintOutputToConsole : IUpdateConsole
    {
        /// <summary>
        ///Print Output to Console 
        ///Only One Argument needed
        /// </summary>
        /// <param name="textToPrint"></param>
        public void UpdateConsle(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }

        /// <summary>
        /// Overloaded Print method which has many to pprint
        /// </summary>
        /// <param name="textToPrint"></param>
        /// <param name="intput"></param>
        /// <param name="textToPrint2"></param>
        public void UpdateConsle(string textToPrint, int intput, string textToPrint2)
        {
            Console.WriteLine(textToPrint, intput, textToPrint2);
        }
    }
}
