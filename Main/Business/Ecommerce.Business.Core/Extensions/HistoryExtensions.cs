using Ecommerce.Business.Core.Interfaces.Common.Directory;
using Ecommerce.Domain;
using Ecommerce.Domain.History;

namespace Ecommerce.Business.Core.Extensions
{
    public static class HistoryExtensions
    {
        /// <summary>
        /// Save an entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="historyService"></param>
        public static async Task SaveHistory<T>(this BaseEntity entity, IHistoryService historyService) where T : BaseEntity, IHistory
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await historyService.SaveObject(entity);
        }

        public static async Task<IList<HistoryObject>> GetHistoryObject(this BaseEntity entity, IHistoryService historyService)
        {
            return await historyService.GetHistoryObjectForEntity(entity);
        }
    }
}
