using System;
using System.IO;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaAPIClient.Factories;
using ApprendaSmokeTestsBase.Repositories;
using ApprendaSmokeTestsBase.ValueItems;
using ApprendaSmokeTestsBase.ValueItems.Implementation;

namespace DefaultApprendaSmokeTests
{
    /// <summary>
    /// Repository which looks for the items in the Archives folder of this project
    /// </summary>
    internal class SimpleLocalSmokeTestApplicationRepository : ISmokeTestApplicationRepository
    {
        private readonly IConnectionSettingsFactory _settingsFactory;

        public SimpleLocalSmokeTestApplicationRepository(IConnectionSettingsFactory factory)
        {
            _settingsFactory = factory;
        }


        public Task<ISmokeTestApplication> GetSmokeTestApplication(string smokeTestApplicationName)
        {
            var settings = _settingsFactory.GetConnectionSettings();
            var dir = settings.IntegrationTestResourcesDirectory;

            string fileName;
            switch (smokeTestApplicationName.ToLower())
            {
                case "helloworld":
                    fileName = "Hello World Archive.zip";
                    break;
                default:
                    throw new ArgumentException($"No smoke test of name {smokeTestApplicationName} is known");
            }

            var fullPath = dir + "\\" + fileName;

            var bytes = File.ReadAllBytes(fullPath);

            ISmokeTestApplication res = new SmokeTestApplication
            {
                SmokeTestApplicationName = smokeTestApplicationName,
                ArchiveContents = bytes
            };

            return Task.FromResult(res);
        }
    }
}
