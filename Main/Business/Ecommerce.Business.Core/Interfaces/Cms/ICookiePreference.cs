using Ecommerce.Domain.Customers;
using Ecommerce.Domain.Stores;

namespace Ecommerce.Business.Core.Interfaces.Cms
{
    public interface ICookiePreference
    {
        IList<IConsentCookie> GetConsentCookies();
        Task<bool?> IsEnable(Customer customer, Store store, string cookieSystemName);
    }
}
