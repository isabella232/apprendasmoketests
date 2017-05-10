using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Factories;
using ApprendaSmokeTestsBase.Repositories;
using ApprendaSmokeTestsBase.Repositories.Implementation;
using ApprendaSmokeTestsBase.Services;
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
            _apiClientFactory = apiClientFactory??new SwaggerBasedApprendaApiClientFactory();
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

        protected Task<CreatedSmokeTestApplication> CreateAppIfDoesNotExist(string smokeTestName)
        {
            throw new NotImplementedException();
        }

        protected Task DeleteAppIfExists(string appAlias)
        {
            throw new NotImplementedException();
        }
    }
}
