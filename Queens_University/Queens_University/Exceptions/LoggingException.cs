using Queens_University.Logging;
using System;

namespace Queens_University.Exceptions
{
    /// <summary>
    /// Throw When Error Occured in Logging
    /// </summary>
    [Serializable]
    class LoggingException : Exception
    {
        ExceptionLoggerHandler _exceptionLoggerhandler;

        public LoggingException(string message): base(message)
        {
            _exceptionLoggerhandler = new ExceptionLoggerHandler(new ExceptionLogger());
            _exceptionLoggerhandler.LogException("\n"+message);
        }
    }
}
