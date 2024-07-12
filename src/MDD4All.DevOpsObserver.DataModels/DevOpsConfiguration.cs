using System.Collections.Generic;

namespace MDD4All.DevOpsObserver.DataModels
{
    public class DevOpsConfiguration
    {
        public List<DevOpsSystem> Systems { get; set; } = new List<DevOpsSystem>();
    }
}
