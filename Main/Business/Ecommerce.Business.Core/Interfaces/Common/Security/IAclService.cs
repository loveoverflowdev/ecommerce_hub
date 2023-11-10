using Ecommerce.Domain;
using Ecommerce.Domain.Customers;
using Ecommerce.Domain.Permissions;
using Ecommerce.Domain.Stores;

namespace Ecommerce.Business.Core.Interfaces.Common.Security
{
    /// <summary>
    /// ACL service interface
    /// </summary>
    public interface IAclService
    {
        /// <summary>
        /// Authorize ACL permission
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="customer">Customer</param>
        /// <returns>true = authorized; otherwise = false</returns>
        bool Authorize<T>(T entity, Customer customer) where T : BaseEntity, IGroupLinkEntity;

        /// <summary>
        /// Authorize whether entity could be accessed in a store
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="storeId">Store identifier</param>
        /// <returns>true - authorized; otherwise, false</returns>
        bool Authorize<T>(T entity, string storeId) where T : BaseEntity, IStoreLinkEntity;
    }
}