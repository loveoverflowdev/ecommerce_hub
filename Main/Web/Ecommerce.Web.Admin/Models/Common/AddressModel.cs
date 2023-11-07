using Ecommerce.Domain.Catalog;
using Ecommerce.Domain.Common;
using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class AddressModel : BaseEntityModel
    {
        public AddressModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            CustomAddressAttributes = new List<AddressAttributeModel>();
        }

        [EcommerceResourceDisplayName("Admin.Address.Fields.AddressName")]
        public string Name { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.FirstName")]
        public string FirstName { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.LastName")]
        public string LastName { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Email")]
        public string Email { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Company")]

        public string Company { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.VatNumber")]
        public string VatNumber { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Country")]
        public string CountryId { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Country")]
        public string CountryName { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.StateProvince")]
        public string StateProvinceId { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.City")]
        public string City { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Address1")]
        public string Address1 { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Address2")]
        public string Address2 { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.PhoneNumber")]
        public string PhoneNumber { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.FaxNumber")]
        public string FaxNumber { get; set; }

        [EcommerceResourceDisplayName("Admin.Address.Fields.Note")]
        public string Note { get; set; }

        //address in HTML format (usually used in grids)
        [EcommerceResourceDisplayName("Admin.Address")]
        public string AddressHtml { get; set; }

        //formatted custom address attributes
        public string FormattedCustomAddressAttributes { get; set; }
        public IList<AddressAttributeModel> CustomAddressAttributes { get; set; }


        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }


        public bool NameEnabled { get; set; }
        public bool FirstNameEnabled { get; set; }
        public bool FirstNameRequired { get; set; }
        public bool LastNameEnabled { get; set; }
        public bool LastNameRequired { get; set; }
        public bool EmailEnabled { get; set; }
        public bool EmailRequired { get; set; }
        public bool CompanyEnabled { get; set; }
        public bool CompanyRequired { get; set; }
        public bool VatNumberEnabled { get; set; }
        public bool VatNumberRequired { get; set; }
        public bool CountryEnabled { get; set; }
        public bool StateProvinceEnabled { get; set; }
        public bool CityEnabled { get; set; }
        public bool CityRequired { get; set; }
        public bool StreetAddressEnabled { get; set; }
        public bool StreetAddressRequired { get; set; }
        public bool StreetAddress2Enabled { get; set; }
        public bool StreetAddress2Required { get; set; }
        public bool ZipPostalCodeEnabled { get; set; }
        public bool ZipPostalCodeRequired { get; set; }
        public bool PhoneEnabled { get; set; }
        public bool PhoneRequired { get; set; }
        public bool FaxEnabled { get; set; }
        public bool FaxRequired { get; set; }
        public bool NoteEnabled { get; set; }

        public bool AddressTypeEnabled { get; set; }
        [EcommerceResourceDisplayName("Address.Fields.AddressType")]
        public AddressType AddressType { get; set; }

        #region Nested classes

        public partial class AddressAttributeModel : BaseEntityModel
        {
            public AddressAttributeModel()
            {
                Values = new List<AddressAttributeValueModel>();
            }

            public string Name { get; set; }

            public bool IsRequired { get; set; }

            /// <summary>
            /// Selected value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<AddressAttributeValueModel> Values { get; set; }
        }

        public partial class AddressAttributeValueModel : BaseEntityModel
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }

        #endregion
    }
}