using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;
using Ecommerce.Web.Common.Models;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class PictureModel : BaseEntityModel, ILocalizedModel<PictureModel.PictureLocalizedModel>
    {
        public PictureModel()
        {
            Locales = new List<PictureLocalizedModel>();
        }
        public string ObjectId { get; set; }

        [EcommerceResourceDisplayName("Admin.Catalog.Picture")]
        public string PictureUrl { get; set; }

        [EcommerceResourceDisplayName("Admin.Catalog.Picture.Fields.AltAttribute")]
        public string AltAttribute { get; set; }

        [EcommerceResourceDisplayName("Admin.Catalog.Picture.Fields.TitleAttribute")]
        public string TitleAttribute { get; set; }


        [EcommerceResourceDisplayName("Admin.Catalog.Picture.Fields.Style")]
        public string Style { get; set; }

        [EcommerceResourceDisplayName("Admin.Catalog.Picture.Fields.ExtraField")]
        public string ExtraField { get; set; }

        public IList<PictureLocalizedModel> Locales { get; set; }

        public partial class PictureLocalizedModel : ILocalizedModelLocal
        {
            public string LanguageId { get; set; }

            [EcommerceResourceDisplayName("Admin.Catalog.Picture.Fields.AltAttribute")]
            public string AltAttribute { get; set; }

            [EcommerceResourceDisplayName("Admin.Catalog.Picture.Fields.TitleAttribute")]
            public string TitleAttribute { get; set; }
        }
    }
}
