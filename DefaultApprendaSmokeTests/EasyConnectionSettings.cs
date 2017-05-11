using System;
using ApprendaAPIClient;
using ApprendaAPIClient.Factories;

namespace DefaultApprendaSmokeTests
{
    internal class EasyConnectionSettings : IConnectionSettings
    {
        public string AppsUrl => "https://apps.apprenda.stella";
        public IUserLogin UserLogin { get; set; } = 
            new UserLogin {UserName = "fluffy@apprenda.com", Password = "password"};

        public IUserLogin AdminUserLogin { get; set; } =
            new UserLogin {UserName = "admin@apprenda.com", Password = "password"};

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
