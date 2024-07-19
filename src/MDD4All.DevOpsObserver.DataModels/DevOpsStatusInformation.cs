using System;

namespace MDD4All.DevOpsObserver.DataModels
{
    public class DevOpsStatusInformation
    {
        public DevOpsStatusInformation() 
        { 
        }

        public DevOpsStatusInformation(string repositoryName, string branch, string gitServerType)
        {
            ID = repositoryName + branch + gitServerType;
            RepositoryName = repositoryName;
            Branch = branch;
            GitServerType = gitServerType;
        }

        public string RepositoryName { get; set; } = "";

        public string ShortName { get; set; } = "";

        public string Alias { get; set; } = "";

        public string WorkflowTitle { get; set; }

        public string Branch { get; set; } = "";

        public DevOpsStatus StatusValue { get; set; } = DevOpsStatus.Unknown;
        
        public int BuildNumber { get; set; }
        
        public DateTime BuildTime { get; set; } = default(DateTime);
        
        public string ImageUrl { get; set; } = "";
        
        public string Color { get; set; } = "";
        
        public string GitServerType { get; set; } = "";

        public string ID { get; set; } = "";
        
        public long SortNumber { get; private set; }
        
        public DateTime LastSeenSuccessfulBuild { get; set; } = default(DateTime);
    }
}
