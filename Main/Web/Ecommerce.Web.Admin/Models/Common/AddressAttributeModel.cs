using Ecommerce.Web.Common.Models;
using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class AddressAttributeModel : BaseEntityModel, ILocalizedModel<AddressAttributeLocalizedModel>
    {
        public AddressAttributeModel()
        {
            Locales = new List<AddressAttributeLocalizedModel>();
        }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Fields.Name")]

        public string Name { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Fields.AttributeControlType")]

        public string AttributeControlTypeName { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }


        public IList<AddressAttributeLocalizedModel> Locales { get; set; }

    }

    public partial class AddressAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.AddressAttributes.Fields.Name")]

        public string Name { get; set; }

    }
}