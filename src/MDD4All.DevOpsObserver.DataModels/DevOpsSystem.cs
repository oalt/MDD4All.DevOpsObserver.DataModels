using System.Collections.Generic;

namespace MDD4All.DevOpsObserver.DataModels
{
    public class DevOpsSystem
    {
        public string GUID { get; set; } = System.Guid.NewGuid().ToString();

        public string Name { get; set; } = string.Empty;

        public string ServerURL { get; set; } = string.Empty;

        public string Tenant {  get; set; } = string.Empty;

        public DevOpsSystemType SystemType { get; set; } = DevOpsSystemType.BitBucketCloud;

        public List<DevOpsObservable> ObservedAutomations { get; set; } = new List<DevOpsObservable>();
    }
}
