using System.Collections.Generic;
using System.Linq;

namespace Assignmet.Segment4
{
    class FilterFromStartLetter
    {
        public List<string> Sort(List<string> theList, char theChar)
        {
            List<string> filtered = theList.Where(a => a.ToLower().StartsWith(theChar.ToString().ToLower())).ToList();

            return filtered;
        }
    }
}
