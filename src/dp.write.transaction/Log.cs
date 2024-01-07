using NLog;
using NLog.Config;
using NLog.Targets;
using System.Text;

namespace dp.write.transaction
{
    internal sealed class Log
    {
        private static readonly Lazy<Log> _instance =
            new(() => new Log());

        private static Logger _log;

        private Log()
        {
            _log = LogManager.GetCurrentClassLogger();
        }

        public static Log Instance => _instance.Value;

        public void Initialize()
        {
            Initialize(new LoggingSettings
            {
                Level = "Trace",
                LevelConsole = "Trace"
            });
        }

        public void Initialize(LoggingSettings loging)
        {
            var fileTarget = new FileTarget
            {
                Encoding = Encoding.UTF8,
                FileName = "${basedir}/logs/${shortdate}.log",
                Layout = "${longdate}|${level}|${message}" +
                " ${exception:format=tostring}",
                ArchiveFileName = "${basedir}/logs/{#}.log",
                KeepFileOpen = false,
                ArchiveDateFormat = "yyyy-MM-dd",
                ArchiveNumbering = ArchiveNumberingMode.Date,
                ArchiveEvery = FileArchivePeriod.Day,
                MaxArchiveFiles = int.MaxValue
            };

            var consoleTarget = new ColoredConsoleTarget
            {
                Layout = "${longdate}|${level}|${message}" +
                " ${exception:format=tostring}",
            };

            LogLevel level = LogLevel.FromString(loging.Level);
            LogLevel levelConsole = LogLevel.FromString(loging.LevelConsole);

            var ruleFile = new LoggingRule("*", level, fileTarget);
            var ruleConsole = new LoggingRule("*", levelConsole, consoleTarget);

            var config = new LoggingConfiguration();

            if (level != LogLevel.Off)
            {
                config.AddTarget("file", fileTarget);
                config.LoggingRules.Add(ruleFile);
            }

            if (levelConsole != LogLevel.Off)
            {
                config.AddTarget("console", consoleTarget);
                config.LoggingRules.Add(ruleConsole);
            }

            LogManager.Configuration = config;
        }

        public static void Info(string message)
        {
            _log.Info(message);
        }

        public static void Warn(string message)
        {
            _log.Warn(message);
        }

        public static void Warn(Exception exception, string message)
        {
            _log.Warn(exception, message);
        }

        public static void Warn(Exception exception)
        {
            _log.Warn(exception);
        }

        public static void Fatal(Exception exception)
        {
            _log.Fatal(exception.ToString());
        }

        public static void Debug(string message)
        {
            _log.Debug(message);
        }

        public static void Error(string message)
        {
            _log.Error(message);
        }

        public static void Error(Exception exception, string message)
        {
            _log.Error(exception, message);
        }
    }
}
