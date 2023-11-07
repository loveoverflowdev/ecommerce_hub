using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity : ParentEntity
    {
        protected BaseEntity()
        {
            UserFields = new List<UserField>();
        }

        public IList<UserField> UserFields { get; set; }

    }
}
