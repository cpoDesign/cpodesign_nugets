namespace CpoDesign.Logger.Nlog
{
    using CpoDesign.Logger.Interface;
    using NLog;
    using System;
    using System.ComponentModel.Composition;

    [Export(typeof (Interface.ILogger))]
    public class NLogger : Interface.ILogger
    {
        private NLog.Logger logger;


        public NLogger()
        {
            try
            {
                logger = LogManager.GetCurrentClassLogger();
            }
            catch
            {
                // ignore
            }

        }

        public void LogException(LogLevel level, string message, Exception exception)
        {

            if (logger != null) logger.LogException(level, message, exception);
        }

        public void Trace<T>(T value)
        {
            if (logger != null) logger.Trace(value);
        }

        public void Trace(IFormatProvider formatProvider, object value)
        {
            throw new NotImplementedException();
        }

        public void Trace<T>(IFormatProvider formatProvider, T value)
        {
            if (logger != null) logger.Trace(formatProvider, value);
        }

        public void Trace(string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(LogMessageGenerator messageFunc)
        {
            if (logger != null) logger.Trace(messageFunc);
        }

        public void TraceException(string message, Exception exception)
        {
            if (logger != null) logger.TraceException(message, exception);
        }

        public void Warn(object value)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, params object[] args)
        {
            if (logger != null) logger.Trace(formatProvider, message, args);
        }

        public void Trace(IFormatProvider formatProvider, string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(object value)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message)
        {
            if (logger != null) logger.Trace(message);
        }

        public void Trace(string message, params object[] args)
        {
            if (logger != null) logger.Trace(message, args);
        }

        public void Trace(string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Trace<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (logger != null) logger.Trace(formatProvider, message, argument);
        }

        public void Trace(IFormatProvider formatProvider, string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Trace<TArgument>(string message, TArgument argument)
        {
            if (logger != null) logger.Trace(message, argument);
        }

        public void Trace(string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            if (logger != null) logger.Trace(formatProvider, message, argument1, argument2);
        }

        public void Trace(string message, object arg1, object arg2, object arg3)
        {
            throw new NotImplementedException();
        }

        public void Trace<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger != null) logger.Trace(message, argument1, argument2);
        }

        public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger != null) logger.Trace(formatProvider, message, argument1, argument2, argument3);
        }

        public void Trace<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            if (logger != null) logger.Trace(message, argument1, argument2, argument3);
        }

        public void Debug<T>(T value)
        {
            if (logger != null) logger.Debug(value);
        }

        public void Debug(IFormatProvider formatProvider, object value)
        {
            throw new NotImplementedException();
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
            if (logger != null) logger.Debug(formatProvider, value);
        }

        public void Debug(string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(LogMessageGenerator messageFunc)
        {
            if (logger != null) logger.Debug(messageFunc);
        }

        public void DebugException(string message, Exception exception)
        {
            if (logger != null) logger.Debug(message, exception);
        }

        public void Error(object value)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, params object[] args)
        {
            if (logger != null) logger.Debug(formatProvider, message, args);
        }

        public void Debug(IFormatProvider formatProvider, string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(object value)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message)
        {
            if (logger != null) logger.Debug(message);
        }

        public void Debug(string message, params object[] args)
        {
            if (logger != null) logger.Debug(message, args);
        }

        public void Debug(string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (logger != null) logger.Debug(formatProvider, message, argument);
        }

        public void Debug(IFormatProvider formatProvider, string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Debug<TArgument>(string message, TArgument argument)
        {
            if (logger != null) logger.Debug(message, argument);
        }

        public void Debug(string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            if (logger != null) logger.Debug(formatProvider, message, argument1, argument2);
        }

        public void Debug(string message, object arg1, object arg2, object arg3)
        {
            throw new NotImplementedException();
        }

        public void Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger != null) logger.Debug(message, argument1, argument2);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger != null) logger.Debug(formatProvider, message, argument1, argument2, argument3);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            if (logger != null) logger.Debug(message, argument1, argument2, argument3);
        }

        public void Info<T>(T value)
        {
            if (logger != null) logger.Info(value);
        }

        public void Info(IFormatProvider formatProvider, object value)
        {
            throw new NotImplementedException();
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
            if (logger != null) logger.Info(formatProvider, value);
        }

        public void Info(string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Info(LogMessageGenerator messageFunc)
        {
            if (logger != null) logger.Info(messageFunc);
        }

        public void InfoException(string message, Exception exception)
        {
            if (logger != null) logger.InfoException(message, exception);
        }

        public void Info(IFormatProvider formatProvider, string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, params object[] args)
        {
            if (logger != null) logger.Info(formatProvider, message, args);
        }

        public void Info(IFormatProvider formatProvider, string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Info(object value)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            if (logger != null) logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            if (logger != null) logger.Info(message, args);
        }

        public void Info(string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (logger != null) logger.Info(formatProvider, message, argument);
        }

        public void Info(IFormatProvider formatProvider, string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Info<TArgument>(string message, TArgument argument)
        {
            if (logger != null) logger.Info(message, argument);
        }

        public void Info(string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            if (logger != null) logger.Info(formatProvider, message, argument1, argument2);
        }

        public void Info(string message, object arg1, object arg2, object arg3)
        {
            throw new NotImplementedException();
        }

        public void Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger != null) logger.Info(message, argument1, argument2);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger != null) logger.Info(formatProvider, message, argument1, argument2, argument3);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            if (logger != null) logger.Info(message, argument1, argument2, argument3);
        }

        public void Warn<T>(T value)
        {
            if (logger != null) logger.Warn(value);
        }

        public void Warn(IFormatProvider formatProvider, object value)
        {
            throw new NotImplementedException();
        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {
            if (logger != null) logger.Warn(formatProvider, value);
        }

        public void Warn(string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(LogMessageGenerator messageFunc)
        {
            if (logger != null) logger.Warn(messageFunc);
        }

        public void WarnException(string message, Exception exception)
        {
            if (logger != null) logger.WarnException(message, exception);
        }

        public void Warn(IFormatProvider formatProvider, string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, params object[] args)
        {
            if (logger != null) logger.Warn(formatProvider, message, args);
        }

        public void Warn(IFormatProvider formatProvider, string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            if (logger != null) logger.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            if (logger != null) logger.Warn(message, args);
        }

        public void Warn(string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (logger != null) logger.Warn(formatProvider, message, argument);
        }

        public void Warn(IFormatProvider formatProvider, string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Warn<TArgument>(string message, TArgument argument)
        {
            if (logger != null) logger.Warn(message, argument);
        }

        public void Warn(string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            if (logger != null) logger.Warn(formatProvider, message, argument1, argument2);
        }

        public void Warn(string message, object arg1, object arg2, object arg3)
        {
            throw new NotImplementedException();
        }

        public void Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger != null) logger.Warn(message, argument1, argument2);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger != null) logger.Warn(formatProvider, message, argument1, argument2, argument3);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            if (logger != null) logger.Warn(message, argument1, argument2, argument3);
        }

        public void Error<T>(T value)
        {
            if (logger != null) logger.Error(value);
        }

        public void Error(IFormatProvider formatProvider, object value)
        {
            throw new NotImplementedException();
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
            if (logger != null) logger.Error(formatProvider, value);
        }

        public void Error(string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);
            Console.WriteLine(exception.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Error(string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Error(LogMessageGenerator messageFunc)
        {
            if (logger != null) logger.Error(messageFunc);
        }

        public void ErrorException(string message, Exception exception)
        {
            if (logger != null) logger.ErrorException(message, exception);
        }

        public void Fatal(object value)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, params object[] args)
        {
            if (logger != null) logger.Error(formatProvider, message, args);
        }

        public void Error(IFormatProvider formatProvider, string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            if (logger != null) logger.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            if (logger != null) logger.Error(message, args);
        }

        public void Error(string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (logger != null) logger.Error(formatProvider, message, argument);
        }

        public void Error(IFormatProvider formatProvider, string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Error<TArgument>(string message, TArgument argument)
        {
            if (logger != null) logger.Error(message, argument);
        }

        public void Error(string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            if (logger != null) logger.Error(formatProvider, message, argument1, argument2);
        }

        public void Error(string message, object arg1, object arg2, object arg3)
        {
            throw new NotImplementedException();
        }

        public void Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger != null) logger.Error(message, argument1, argument2);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger != null) logger.Error(formatProvider, message, argument1, argument2, argument3);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            if (logger != null) logger.Error(message, argument1, argument2, argument3);
        }

        public void Fatal<T>(T value)
        {
            if (logger != null) logger.Fatal(value);
        }

        public void Fatal(IFormatProvider formatProvider, object value)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
            if (logger != null) logger.Fatal(formatProvider, value);
        }

        public void Fatal(string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception exception)
        {
            if (logger != null) logger.FatalException(message, exception);
        }

        public void Fatal(string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(LogMessageGenerator messageFunc)
        {
            if (logger != null) logger.Fatal(messageFunc);
        }

        public void FatalException(string message, Exception exception)
        {
            if (logger != null) logger.FatalException(message, exception);
        }

        public void Fatal(IFormatProvider formatProvider, string message, object argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, params object[] args)
        {
            if (logger != null) logger.Fatal(formatProvider, message, args);
        }

        public void Fatal(IFormatProvider formatProvider, string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            if (logger != null) logger.Fatal(message);
        }

        public void Fatal(string message, params object[] args)
        {
            if (logger != null) logger.Fatal(message, args);
        }

        public void Fatal(string message, sbyte argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, string argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (logger != null) logger.Fatal(formatProvider, message, argument);
        }

        public void Fatal(IFormatProvider formatProvider, string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Fatal<TArgument>(string message, TArgument argument)
        {
            if (logger != null) logger.Fatal(message, argument);
        }

        public void Fatal(string message, uint argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, ulong argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, bool argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, byte argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, char argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, decimal argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, double argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, float argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, int argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, string message, long argument)
        {
            throw new NotImplementedException();
        }

        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            if (logger != null) logger.Fatal(formatProvider, message, argument1, argument2);
        }

        public void Fatal(string message, object arg1, object arg2, object arg3)
        {
            throw new NotImplementedException();
        }

        public void Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger != null) logger.Fatal(message, argument1, argument2);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger != null) logger.Fatal(formatProvider, message, argument1, argument2, argument3);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            if (logger != null) logger.Fatal(message, argument1, argument2, argument3);
        }
    }
}
