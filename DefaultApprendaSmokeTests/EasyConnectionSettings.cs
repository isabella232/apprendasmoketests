using System;
using ApprendaAPIClient;
using ApprendaSmokeTestsBase.Factories;

namespace DefaultApprendaSmokeTests
{
    internal class EasyConnectionSettings : IConnectionSettings
    {
        public string AppsUrl => "https://apps.apprenda.yards";
        public IUserLogin UserLogin { get; set; } = new UserLogin {UserName = "fluffy@apprenda.com", Password = "password"};

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
