using Assignmet.Common;

namespace Assignmet.Segment1
{
    class MultipicationFinder
    {
      
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
