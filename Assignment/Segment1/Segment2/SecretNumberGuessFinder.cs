using Assignmet.Common;
using System;

namespace Assignmet.Segment2
{
    public class SecretNumberGuessFinder
    {
        /// <summary>
        /// Metod runs until user Enter correct Secret Number : 42
        /// if user enter 42 --> Print Corrent and close the Aplication
        /// </summary>
        public void GessSecretNumber()
        {
            PrintOutputToConsole objPrintOutputToConsole = new PrintOutputToConsole();
            SecretNmber42 objScretNmber42 = new SecretNmber42();
            string line;
            objPrintOutputToConsole.UpdateConsle(Constants.WELCOME_ADVICE);
            objPrintOutputToConsole.UpdateConsle(string.Empty);
            do
            {
                line = Console.ReadLine();
                int number;
                if (Int32.TryParse(line, out number))
                {
                    if (objScretNmber42.EvalateSecretNumber(number))
                    {
                        objPrintOutputToConsole.UpdateConsle(Constants.NUMBER_RECEIVED, number, Constants.CORRECT);
                        Environment.Exit(0);
                    }
                    else
                    {
                        objPrintOutputToConsole.UpdateConsle(Constants.NUMBER_RECEIVED, number, Constants.INCORRECT);
                    }
                }
                else
                {
                    objPrintOutputToConsole.UpdateConsle(Constants.ERROR_MESSAGE);
                }
            } while (line != null);
        }
    }
}
