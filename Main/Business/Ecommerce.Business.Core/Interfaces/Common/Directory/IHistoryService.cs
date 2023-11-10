using Ecommerce.Domain;
using Ecommerce.Domain.History;

namespace Ecommerce.Business.Core.Interfaces.Common.Directory
{
    /// <summary>
    /// History service interface
    /// </summary>
    public interface IHistoryService
    {
        Task SaveObject<T>(T entity) where T : BaseEntity;
        Task<IList<T>> GetHistoryForEntity<T>(BaseEntity entity) where T : BaseEntity;
        Task<IList<HistoryObject>> GetHistoryObjectForEntity(BaseEntity entity);
    }
}