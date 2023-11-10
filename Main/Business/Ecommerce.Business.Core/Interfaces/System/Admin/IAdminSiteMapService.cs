using Ecommerce.Domain.Admin;

namespace Ecommerce.Business.Core.Interfaces.System.Admin
{
    public interface IAdminSiteMapService
    {
        Task<IList<AdminSiteMap>> GetSiteMap();
    }
}
