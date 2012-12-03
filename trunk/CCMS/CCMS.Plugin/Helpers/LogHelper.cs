using System;
using System.Collections.Generic;
using System.Text;
namespace CCMS.Helpers
{
    public class LogHelper
    {
        //private static Type _currentType = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        //private static log4net.ILog _log = null;
        static LogHelper()
        {
            //_log = log4net.LogManager.GetLogger(_currentType);
            //log4net.Config.XmlConfigurator.Configure();
        }
        public static void Info(object message)
        {
            //if (_log.IsInfoEnabled)
            //{
            //    _log.Info(message);
            //}
        }
        public static void Info(object message, Exception exception)
        {
            //if (_log.IsInfoEnabled)
            //{
            //    _log.Info(message, exception);
            //}
        }
        public static void Error(object message)
        {
            //if (_log.IsErrorEnabled)
            //{
            //    _log.Error(message);
            //}
        }
        public static void Error(object message, Exception exception)
        {
            //if (_log.IsErrorEnabled)
            //{
            //    _log.Error(message, exception);
            //}
        }
        public static void Debug(object message)
        {
            //if (_log.IsDebugEnabled)
            //{
            //    _log.Debug(message);
            //}
        }
        public static void Debug(object message, Exception exception)
        {
            //if (_log.IsDebugEnabled)
            //{
            //    _log.Debug(message, exception);
            //}
        }
        public static void Fatal(object message)
        {
            //if (_log.IsFatalEnabled)
            //{
            //    _log.Fatal(message);
            //}
        }
        public static void Fatal(object message, Exception exception)
        {
            //if (_log.IsFatalEnabled)
            //{
            //    _log.Fatal(message, exception);
            //}
        }
        public static void Warn(object message)
        {
            //if (_log.IsWarnEnabled)
            //{
            //    _log.Warn(message);
            //}
        }
        public static void Warn(object message, Exception exception)
        {
            //if (_log.IsWarnEnabled)
            //{
            //    _log.Fatal(message, exception);
            //}
        }
    }
}
