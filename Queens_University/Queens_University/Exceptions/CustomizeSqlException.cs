using Queens_University.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.Exceptions
{
    /// <summary>
    /// Throw When SQL Connection Cannot be recognize
    /// </summary>
    [Serializable]
    class CustomizeSqlException : Exception
    {
        ExceptionLoggerHandler _exceptionLoggerhandler;
        public CustomizeSqlException(string message)
            : base(message)
        {
            _exceptionLoggerhandler = new ExceptionLoggerHandler(new ExceptionLogger());
            _exceptionLoggerhandler.LogException("\n"+message);  
        }
    }
}
