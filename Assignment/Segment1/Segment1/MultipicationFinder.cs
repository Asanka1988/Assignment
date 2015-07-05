using Assignmet.Common;

namespace Assignmet.Segment1
{
    class MultipicationFinder
    {
      /// <summary>
      /// Write 1- 100 Nmbers
        /// Replace *3 multiples  with : Support
        /// Repplavce *5 multiples  with : Training
        /// Relace both *3 & *5 multiples : SupportTraining 
      /// </summary>
        public void FindDivider()
        {
            PrintOutputToConsole objPrintOutputToConsole = new PrintOutputToConsole();

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    objPrintOutputToConsole.UpdateConsle(Constants.SupportTraining);
                }
                else if (i % 3 == 0)
                {
                    objPrintOutputToConsole.UpdateConsle(Constants.Support);
                }
                
                else if (i % 5 == 0)
                {
                    objPrintOutputToConsole.UpdateConsle(Constants.Training);
                }
                else
                {
                    objPrintOutputToConsole.UpdateConsle(i.ToString());
                }
            }
        }

    }
}
