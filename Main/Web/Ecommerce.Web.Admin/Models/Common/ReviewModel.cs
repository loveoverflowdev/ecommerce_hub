using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class ReviewModel : BaseEntityModel
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        [EcommerceResourceDisplayName("Admin.Customers.Customers.Reviews.Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the review text
        /// </summary>
        [EcommerceResourceDisplayName("Admin.Customers.Customers.Reviews.Review")]
        public string ReviewText { get; set; }
    }
}