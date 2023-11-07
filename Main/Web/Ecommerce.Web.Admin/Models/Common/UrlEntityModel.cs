using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class UrlEntityModel : BaseEntityModel
    {
        [EcommerceResourceDisplayName("admin.configuration.senames.Name")]
        
        public string Name { get; set; }

        [EcommerceResourceDisplayName("admin.configuration.senames.EntityId")]
        public string EntityId { get; set; }

        [EcommerceResourceDisplayName("admin.configuration.senames.EntityName")]
        public string EntityName { get; set; }

        [EcommerceResourceDisplayName("admin.configuration.senames.IsActive")]
        public bool IsActive { get; set; }

        [EcommerceResourceDisplayName("admin.configuration.senames.Language")]
        public string Language { get; set; }

        [EcommerceResourceDisplayName("admin.configuration.senames.Details")]
        public string DetailsUrl { get; set; }
    }
}