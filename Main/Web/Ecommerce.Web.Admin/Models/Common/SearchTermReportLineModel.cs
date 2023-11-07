using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class SearchTermReportLineModel : BaseModel
    {
        [EcommerceResourceDisplayName("Admin.SearchTermReport.Keyword")]
        public string Keyword { get; set; }

        [EcommerceResourceDisplayName("Admin.SearchTermReport.Count")]
        public int Count { get; set; }
    }
}
