using Ecommerce.Domain.Permissions;

namespace Ecommerce.Business.Core.Utilities.Common.Security
{
    /// <summary>
    /// Standard permissions
    /// </summary>
    public static partial class StandardPermission
    {
        //admin area permissions
        public static readonly Permission AccessAdminPanel = new Permission
        {
            Name = "Access admin",
            SystemName = PermissionSystemName.AccessAdminPanel,
            Area = "Admin area",
            Category = "AccessAdmin"
        };
    }
}