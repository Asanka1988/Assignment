using Queens_University.Exceptions;
using System.Configuration;
using System.IO;

namespace Queens_University.Logging
{
    /// <summary>
    /// Log Excepptions to Logger
    /// </summary>
    class ExceptionLogger : ILogger
    {
        public void LogToTextFile(string error)
        {
            string logfile = ConfigurationSettings.AppSettings[Constants.LOG_FILE_PATH];
            try
            {
                System.IO.File.AppendAllText(logfile, error);
            }
            catch (ConfigurationException ex)
            {
                throw new ConfigurationSettingException(ex.Message);
            }
            catch (IOException ex)
            {
                throw new LoggingException(ex.Message);
            }
        }
    }
}
