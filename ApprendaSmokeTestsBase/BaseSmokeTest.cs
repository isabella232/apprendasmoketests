using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaAPIClient.Factories;
using ApprendaAPIClient.Services;
using ApprendaSmokeTestsBase.Repositories;
using ApprendaSmokeTestsBase.Repositories.Implementation;
using ApprendaSmokeTestsBase.Services;
using ApprendaSmokeTestsBase.ValueItems;
using ApprendaSmokeTestsBase.ValueItems.Implementation;

namespace ApprendaSmokeTestsBase
{
    /// <summary>
    /// Base class for any smoke test, that provides the items you need to do full integration tests with reporting
    /// </summary>
    public abstract class BaseSmokeTest
    {
        private readonly IConnectionSettingsFactory _connectionSettingsFactory;
        private readonly ISmokeTestApplicationRepository _smokeTestApplicationRepository;
        private readonly ITelemetryReportingService _reportingService;
        private readonly IApprendaApiClientFactory _apiClientFactory;
        private readonly IUserLoginRepository _userLoginRepository;

        protected BaseSmokeTest(IConnectionSettingsFactory connectionSettingsFactory, 
            ISmokeTestApplicationRepository smokeTestApplicationRepository, 
            ITelemetryReportingService reportingService,
            IUserLoginRepository userLoginRepository = null,
            IApprendaApiClientFactory apiClientFactory = null)
        {
            _connectionSettingsFactory = connectionSettingsFactory;
            _smokeTestApplicationRepository = smokeTestApplicationRepository;
            _reportingService = reportingService;
            _apiClientFactory = apiClientFactory??new ApprendaApiClientFactory(_connectionSettingsFactory);
            _userLoginRepository = userLoginRepository??new SingleUserLoginRepository(_connectionSettingsFactory);
        }


        protected IApprendaTestSession StartSession([CallerMemberName] string testName = "")
        {
            var connectionProperties = _connectionSettingsFactory.GetConnectionSettings();
            if (connectionProperties.UserLogin == null)
            {
                connectionProperties.UserLogin = _userLoginRepository.GetNextAvailableUserLogin();
            }
            var session = new ApprendaTestSession(_apiClientFactory, connectionProperties, _reportingService, testName);

            //ping that we've started!
            _reportingService?.ReportInfo($"Starting test {testName}", new List<string> { "teststart", testName });

            return session;
        }

        protected IApprendaTestSession StartAdminSession([CallerMemberName] string testName = "")
        {
            var connectionProperties = _connectionSettingsFactory.GetConnectionSettings();
            if (connectionProperties.AdminUserLogin == null)
            {
                connectionProperties.AdminUserLogin = _userLoginRepository.GetAdminUserLogin();
            }
            var session = new ApprendaTestSession(_apiClientFactory, connectionProperties, _reportingService, testName, connectionProperties.AdminUserLogin);

            //ping that we've started!
            _reportingService?.ReportInfo($"Starting test {testName} as admin", new List<string> { "teststart", testName });

            return session;
        }

        protected IApprendaTestSession StartSession(string userName, string password, [CallerMemberName] string testName = "")
        {
            var connectionProperties = _connectionSettingsFactory.GetConnectionSettings();
            connectionProperties.UserLogin = new UserLogin
            {
                UserName = userName,
                Password = password
            };

            return new ApprendaTestSession(_apiClientFactory, connectionProperties, _reportingService, testName);
        }

        protected Task<CreatedSmokeTestApplication> CreateAppIfDoesNotExist(string smokeTestname)
        {
            return CreateAppIfDoesNotExist(smokeTestname, smokeTestname);
        }

        protected async Task<CreatedSmokeTestApplication> CreateAppIfDoesNotExist(string smokeTestName, string appAlias)
        {
            var baseSmokeTest = await _smokeTestApplicationRepository.GetSmokeTestApplication(smokeTestName);
            var client = GetClient();
            var upgraydd = new CreatedSmokeTestApplication(client, baseSmokeTest) {AppAlias = appAlias};
            //does it exist?

            bool exists;
            try
            {
                var get = await client.GetApplication(smokeTestName);
                exists = get != null;
            }
            catch (Exception)
            {
                exists = false;
            }

            upgraydd.WasCreated = !exists;
            return upgraydd;
        }

        protected async Task DeleteAppIfExists(string appAlias)
        {
            var client = GetClient();

            try
            {
                await client.DeleteApplication(appAlias);
            }
            catch (Exception)
            {
            }
        }

        private IApprendaApiClient GetClient()
        {
            var client = _reportingService == null
                ? _apiClientFactory.GetV1Client()
                : _apiClientFactory.GetV1Client(_reportingService);
            return client;
        }
    }
}
