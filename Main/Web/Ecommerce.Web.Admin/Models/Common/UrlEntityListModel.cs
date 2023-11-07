using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class UrlEntityListModel : BaseModel
    {
        public UrlEntityListModel()
        {
            AvailableActiveOptions = new List<SelectListItem>();
        }

        [EcommerceResourceDisplayName("admin.configuration.senames.Name")]
        public string SeName { get; set; }

        [EcommerceResourceDisplayName("admin.configuration.senames.Active")]
        public int SearchActiveId { get; set; }
        public IList<SelectListItem> AvailableActiveOptions { get; set; }
    }
}