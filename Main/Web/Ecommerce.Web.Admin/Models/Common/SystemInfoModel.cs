using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class SystemInfoModel : BaseModel
    {
        public SystemInfoModel()
        {
            ServerVariables = new List<ServerVariableModel>();
            LoadedAssemblies = new List<LoadedAssembly>();
            SystemWarnings = new List<SystemWarningModel>();
        }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.MachineName")]
        public string MachineName { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.EcommerceVersion")]
        public string EcommerceVersion { get; set; }
        
        [EcommerceResourceDisplayName("Admin.System.SystemInfo.GitBranch")]
        public string GitBranch { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.GitCommit")]
        public string GitCommit { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.OperatingSystem")]
        public string OperatingSystem { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.WebRootPath")]
        public string WebRootPath { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.ContentRootPath")]
        public string ContentRootPath { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.EnvironmentName")]
        public string EnvironmentName { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.ApplicationTime")]
        public DateTime ApplicationTime { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.UTCTime")]
        public DateTime UtcTime { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.Scheme")]
        public string RequestScheme { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.IsHttps")]
        public bool IsHttps { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.ServerVariables")]
        public IList<ServerVariableModel> ServerVariables { get; set; }

        [EcommerceResourceDisplayName("Admin.System.SystemInfo.LoadedAssemblies")]
        public IList<LoadedAssembly> LoadedAssemblies { get; set; }

        public IList<SystemWarningModel> SystemWarnings { get; set; }

        public partial class ServerVariableModel : BaseModel
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public partial class LoadedAssembly : BaseModel
        {
            public string FullName { get; set; }
            public string Location { get; set; }
        }

        public partial class SystemWarningModel : BaseModel
        {
            public SystemWarningLevel Level { get; set; }

            public string Text { get; set; }

            public enum SystemWarningLevel
            {
                Pass,
                Warning,
                Fail
            }
        }
    }
}