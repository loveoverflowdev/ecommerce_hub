using Ecommerce.Business.Common.Services.Addresses;
using Ecommerce.Business.Common.Services.Configuration;
using Ecommerce.Business.Common.Services.Directory;
using Ecommerce.Business.Common.Services.ExportImport;
using Ecommerce.Business.Common.Services.Localization;
using Ecommerce.Business.Common.Services.Logging;
using Ecommerce.Business.Common.Services.Pdf;
using Ecommerce.Business.Common.Services.Security;
using Ecommerce.Business.Common.Services.Seo;
using Ecommerce.Business.Common.Services.Stores;
using Ecommerce.Business.Core.Interfaces.Common.Addresses;
using Ecommerce.Business.Core.Interfaces.Common.Configuration;
using Ecommerce.Business.Core.Interfaces.Common.Directory;
using Ecommerce.Business.Core.Interfaces.Common.Localization;
using Ecommerce.Business.Core.Interfaces.Common.Logging;
using Ecommerce.Business.Core.Interfaces.Common.Pdf;
using Ecommerce.Business.Core.Interfaces.Common.Security;
using Ecommerce.Business.Core.Interfaces.Common.Seo;
using Ecommerce.Business.Core.Interfaces.Common.Stores;
using Ecommerce.Business.Core.Interfaces.ExportImport;
using Ecommerce.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Business.Common.Startup
{
    public class StartupApplication : IStartupApplication
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            RegisterCommonService(services);
            RegisterDirectoryService(services);
            RegisterConfigurationService(services);
            RegisterLocalizationService(services);
            RegisterLoggingService(services);
            RegisterSecurityService(services);
            RegisterSeoService(services);
            RegisterStoresService(services);
            RegisterExportImportService(services);
        }
        public void Configure(IApplicationBuilder application, IWebHostEnvironment webHostEnvironment)
        {

        }
        public int Priority => 100;
        public bool BeforeConfigure => false;

        private void RegisterCommonService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAddressAttributeParser, AddressAttributeParser>();
            serviceCollection.AddScoped<IAddressAttributeService, AddressAttributeService>();
            serviceCollection.AddScoped<IUserFieldService, UserFieldService>();
            serviceCollection.AddScoped<IHistoryService, HistoryService>();
            serviceCollection.AddScoped<IPdfService, HtmlToPdfService>();

        }
        private void RegisterDirectoryService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDateTimeService, DateTimeService>();

            serviceCollection.AddScoped<ICountryService, CountryService>();
            serviceCollection.AddScoped<ICurrencyService, CurrencyService>();
            serviceCollection.AddScoped<IExchangeRateService, ExchangeRateService>();
            serviceCollection.AddScoped<IGroupService, GroupService>();
        }
        private void RegisterConfigurationService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISettingService, SettingService>();
        }
        private void RegisterLocalizationService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITranslationService, TranslationService>();
            serviceCollection.AddScoped<ILanguageService, LanguageService>();
        }
        private void RegisterLoggingService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICustomerActivityService, CustomerActivityService>();
            serviceCollection.AddScoped<ILogger, DefaultLogger>();

        }
        private void RegisterSecurityService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPermissionService, PermissionService>();
            serviceCollection.AddScoped<IAclService, AclService>();
            serviceCollection.AddScoped<IEncryptionService, EncryptionService>();
            serviceCollection.AddScoped<IPermissionProvider, PermissionProvider>();
        }

        private void RegisterSeoService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISlugService, SlugService>();
        }


        private void RegisterStoresService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStoreService, StoreService>();
        }

        private void RegisterExportImportService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISchemaProperty<CountryStates>, CountrySchemaProperty>();

            serviceCollection.AddScoped<IExportProvider, ExcelExportProvider>();
            serviceCollection.AddScoped(typeof(IExportManager<>), typeof(ExportManager<>));

            serviceCollection.AddScoped<IImportDataProvider, ExcelImportProvider>();
            serviceCollection.AddScoped(typeof(IImportManager<>), typeof(ImportManager<>));

            serviceCollection.AddScoped<IImportDataObject<CountryStates>, CountryImportDataObject>();
        }
    }
}
