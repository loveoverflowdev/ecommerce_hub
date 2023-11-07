using Ecommerce.Web.Common.Models;
using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class AddressAttributeValueModel : BaseEntityModel, ILocalizedModel<AddressAttributeValueLocalizedModel>
    {
        public AddressAttributeValueModel()
        {
            Locales = new List<AddressAttributeValueLocalizedModel>();
        }

        public string AddressAttributeId { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.Name")]

        public string Name { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<AddressAttributeValueLocalizedModel> Locales { get; set; }

    }

    public partial class AddressAttributeValueLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.Name")]

        public string Name { get; set; }
    }
}