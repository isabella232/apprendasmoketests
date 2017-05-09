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

        protected BaseSmokeTest(IConnectionSettingsFactory connectionSettingsFactory, 
            ISmokeTestApplicationRepository smokeTestApplicationRepository, 
            ITelemetryReportingService reportingService, 
            IApprendaApiClientFactory apiClientFactory)
        {
            _connectionSettingsFactory = connectionSettingsFactory;
            _smokeTestApplicationRepository = smokeTestApplicationRepository;
            _reportingService = reportingService;
            _apiClientFactory = apiClientFactory;
        }


        protected IApprendaTestSession StartSession()
        {
            var session = new ApprendaTestSession(_apiClientFactory);
            return session;
        }
    }
}
