using Ecommerce.Domain.Data;
using Ecommerce.SharedKernel.Attributes;

namespace Ecommerce.Domain
{
    public abstract class ParentEntity
    {
        protected ParentEntity()
        {
            _id = UniqueIdentifier.New;
        }

        [DBFieldName("_id")]
        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _id = UniqueIdentifier.New;
                else
                    _id = value;
            }
        }

        private string _id;

    }
}
