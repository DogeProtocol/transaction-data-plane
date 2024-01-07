using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp.write.transaction
{
    public static class Config
    {
        public static void Create(Settings settings)
        {
            Log.Instance.Initialize(settings.Logging);
            Configuration.Queue = settings.Queue;
            Configuration.DpClient = settings.DpClient;
            Configuration.State = settings.State;
            Log.Info("dp config initialized");
        }
    }
}
