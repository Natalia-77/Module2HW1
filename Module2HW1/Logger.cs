using System;
using System.IO;
using System.Text;

namespace Module2HW1
{
    public enum LogType
    {
        Error,
        Info,
        Warning
    }

    public sealed class Logger
    {
        private readonly StringBuilder _sb = new ();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance { get; } = new Logger();

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

        private void WriteToFile(string text)
        {
            string fileName = "log.txt";
            fileName = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\"), fileName);
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, text);
            }
            else
            {
                File.Create(fileName);
            }
        }

        private void WriteMessages(LogType logType, string textmessage)
        {
            string textlog = logType switch
            {
                LogType.Error => $"{DateTime.Now.ToLongTimeString()} : {LogType.Error} : {textmessage}",
                LogType.Info => $"{DateTime.Now.ToLongTimeString()} : {LogType.Info} : {textmessage}",
                LogType.Warning => $"{DateTime.Now.ToLongTimeString()} : {LogType.Warning} : {textmessage}",
                _ => string.Empty,
            };
            _sb.AppendLine(textlog);
            Console.WriteLine($"{textlog}");
            WriteToFile(_sb.ToString());
        }
    }
}
