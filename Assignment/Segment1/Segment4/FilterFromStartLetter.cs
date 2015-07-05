using System.Collections.Generic;
using System.Linq;

namespace Assignmet.Segment4
{
    class FilterFromStartLetter
    {
        /// <summary>value
        /// Filtered the given strings with their First letter is equals to the given char Value 
        /// </summary>
        /// <param name="theList"></param>
        /// <param name="theChar"></param>
        /// <returns></returns>
        public List<string> Sort(List<string> theList, char theChar)
        {
            if (theList.Count > 0)
            {
                List<string> filtered = theList.Where(a => a.ToLower().StartsWith(theChar.ToString().ToLower())).ToList();

                return filtered;
            }
            return null;
        }
    }
}
