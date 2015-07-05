
namespace Queens_University.Logging
{
    /// <summary>
    /// Handel relevent Exception
    /// </summary>
    public class ExceptionLoggerHandler
    {
        private ILogger _logger;
        public ExceptionLoggerHandler(ILogger aLogger)
        {
            this._logger = aLogger;
        }

        /// <summary>
        /// Call to Write Exception Details to text file
        /// </summary>
        /// <param name="aException"></param>
        public void LogException(string aException)
        {
            string strMessage = aException;
            this._logger.LogToTextFile(strMessage);
        }  
    }
}
