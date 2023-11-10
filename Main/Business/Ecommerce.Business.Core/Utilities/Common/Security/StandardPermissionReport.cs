using Ecommerce.Domain.Permissions;

namespace Ecommerce.Business.Core.Utilities.Common.Security
{
    public static partial class StandardPermission
    {
        private static string CategoryReport => "Reports";

        public static readonly Permission ManageReports = new()
        {
            Name = "Manage Reports",
            SystemName = PermissionSystemName.Reports,
            Area = "Admin area",
            Category = CategoryReport
        };

    }
}
