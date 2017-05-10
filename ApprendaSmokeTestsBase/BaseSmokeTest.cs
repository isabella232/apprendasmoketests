using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Factories;
using ApprendaSmokeTestsBase.Repositories;
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
            IApprendaApiClientFactory apiClientFactory, IUserLoginRepository userLoginRepository)
        {
            _connectionSettingsFactory = connectionSettingsFactory;
            _smokeTestApplicationRepository = smokeTestApplicationRepository;
            _reportingService = reportingService;
            _apiClientFactory = apiClientFactory;
            _userLoginRepository = userLoginRepository;
        }


        protected IApprendaTestSession StartSession()
        {
            var connectionProperties = _connectionSettingsFactory.GetConnectionSettings();
            if (connectionProperties.UserLogin == null)
            {
                connectionProperties.UserLogin = _userLoginRepository.GetNextAvailableUserLogin();
            }
            var session = new ApprendaTestSession(_apiClientFactory, connectionProperties);
            return session;
        }

        protected IApprendaTestSession StartSession(string userName, string password)
        {
            var connectionProperties = _connectionSettingsFactory.GetConnectionSettings();
            connectionProperties.UserLogin = new UserLogin
            {
                UserName = userName,
                Password = password
            };

            return new ApprendaTestSession(_apiClientFactory, connectionProperties);
        }
    }
}
