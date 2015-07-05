using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.ValidateInput
{
    class ValidateInputTextField : InputValidation
    {
        /// <summary>
        /// Mzake sre that Name and Average texboxes are Not Empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsValidInput(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                return true;
            }
            else
                return false;
        }

    }
}
