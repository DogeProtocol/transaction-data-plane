namespace dp.write.transaction
{
    public class Configuration
    {
        public static QueueSettings Queue { get; set; }
        public static DpClientSettings DpClient { get; set; }
        public static StateSettings State { get; set; }
    }
}
