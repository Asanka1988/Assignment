using Queens_University.Logging;
using System;

namespace Queens_University.Exceptions
{
    /// <summary>
    /// Throw Exception when Configeration setting canbe accessible 
    /// </summary>
    [Serializable]
    public class ConfigurationSettingException : Exception
    {
        ExceptionLoggerHandler _exceptionLoggerhandler; 
        public ConfigurationSettingException(string message) : base(message) {

            _exceptionLoggerhandler = new ExceptionLoggerHandler(new ExceptionLogger());
            _exceptionLoggerhandler.LogException("\n"+message);  
        }
    }
}
