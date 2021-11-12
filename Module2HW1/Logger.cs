using System;
using System.Text;

namespace Module2HW1
{
    public class Logger
    {
        private readonly StringBuilder _builder = new StringBuilder();
        private static readonly Logger _instance = new Logger();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance { get => _instance; }

        public void Error(string text)
        {
            WriteMessages(LogType.Error, text);
        }

        public void Info(string text)
        {
            WriteMessages(LogType.Info, text);
        }

        public void Warning(string text)
        {
            WriteMessages(LogType.Warning, text);
        }

        public string GetLogger() => _builder.ToString();

        private void WriteMessages(LogType logType, string text)
        {
            var log = $"{DateTime.UtcNow.ToLongTimeString()} : {logType} : {text}";
            _builder.AppendLine(log);
            Console.WriteLine($"{log}");
        }
    }
}
