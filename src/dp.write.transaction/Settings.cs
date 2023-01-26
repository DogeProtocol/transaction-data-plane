using NLog;

namespace dp.write.transaction
{
    public class Settings
    {
        public QueueSettings Queue { get; set; } = new QueueSettings();
        public DpClientSettings DpClient { get; set; } = new DpClientSettings();
        public StateSettings State { get; set; } = new StateSettings();
        public LoggingSettings Logging { get; set; } = new LoggingSettings();
    }
    public class QueueSettings
    {
        public string Connectionstring { get; set; } = string.Empty; 
    }
    public class DpClientSettings 
    {
        public string Url { get; set; } = string.Empty;
    }
    public class StateSettings
    {
        public string Initialize { get; set; } = string.Empty;
        public string Marked { get; set; } = string.Empty;
        public string Complete { get; set; } = string.Empty;
    }
    public class LoggingSettings
    {
        public string Level { get; set; } = LogLevel.Trace.Name;
        public string LevelConsole { get; set; } = LogLevel.Trace.Name;
    }
}
