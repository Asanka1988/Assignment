using Assignmet.Segment1;
using Assignmet.Segment2;
using Assignmet.Segment4;
using System;
using System.Collections.Generic;

namespace Assignmet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call Segment 1 (Find the Divider)
            new MultipicationFinder().FindDivider();

            //Call the Segment4 (Filter list from startLetter of the include strings)
            List<string> testData = new List<string>() { "Asanka", "apple", "bat", "cat", "Air", "aTom" };
            List<string> FilteredData = new FilterFromStartLetter().Sort(testData, 'A');

            //Call Segment2 (Check the user guess about Secret number )
            new SecretNumberGuessFinder().GessSecretNumber();

            

            Console.ReadLine();
        }
    }
}
