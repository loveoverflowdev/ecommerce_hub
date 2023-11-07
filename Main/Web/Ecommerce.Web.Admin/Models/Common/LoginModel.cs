using Ecommerce.Infrastructure.ModelBinding;
using Ecommerce.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Web.Admin.Models.Common
{
    public partial class LoginModel : BaseModel
    {
        public LoginModel()
        {
            Captcha = new CaptchaModel();
        }
        [DataType(DataType.EmailAddress)]
        [EcommerceResourceDisplayName("Account.Login.Fields.Email")]
        public string Email { get; set; }

        public bool UsernamesEnabled { get; set; }
        [EcommerceResourceDisplayName("Account.Login.Fields.UserName")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [EcommerceResourceDisplayName("Account.Login.Fields.Password")]
        public string Password { get; set; }

        [EcommerceResourceDisplayName("Account.Login.Fields.RememberMe")]
        public bool RememberMe { get; set; }

        public bool DisplayCaptcha { get; set; }
        public ICaptchaValidModel Captcha { get; set; }
    }
}