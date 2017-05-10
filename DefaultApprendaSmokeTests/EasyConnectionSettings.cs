using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Factories;
using ApprendaSmokeTestsBase.ValueItems;
using ApprendaSmokeTestsBase.ValueItems.Implementation;

namespace DefaultApprendaSmokeTests
{
    internal class EasyConnectionSettings : IConnectionSettings
    {
        public string AppsUrl => "https://apps.apprenda.yards";
        public IUserLogin UserLogin { get; set; } = new UserLogin {UserName = "admin@apprenda.com", Password = "password"};

        public string IntegrationTestResourcesDirectory => "";
        public string RepositoryServer => "";
        public string AdminTenantAlias => string.Empty;
    }

    internal  class EasyConnectionSettingsFactory : IConnectionSettingsFactory
    {
        public IConnectionSettings GetConnectionSettings()
        {
            return new EasyConnectionSettings();
        }
    }
}
