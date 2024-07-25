using System.Collections.Generic;

namespace MDD4All.DevOpsObserver.DataModels
{
    public class DevOpsConfiguration
    {
        public string OrganizationTitle { get; set; } = string.Empty;

        public List<DevOpsSystem> Systems { get; set; } = new List<DevOpsSystem>();
    }
}
