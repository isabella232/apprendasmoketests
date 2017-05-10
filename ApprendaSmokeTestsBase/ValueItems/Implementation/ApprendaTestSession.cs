using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaSmokeTestsBase.Factories;
using ApprendaSmokeTestsBase.Services;

namespace ApprendaSmokeTestsBase.ValueItems.Implementation
{
    /// <summary>
    /// Holds authentication info, and exposes a client via it
    /// </summary>
    internal class ApprendaTestSession : IApprendaTestSession
    {
        private readonly IApprendaApiClientFactory _clientFactory;
        private IApprendaApiClient _currentApiClient;
        private readonly IConnectionSettings _connectionSettings;
        private readonly ITelemetryReportingService _reportingService;
        private readonly string _testName;

        private string _sessionToken;

        public ApprendaTestSession(IApprendaApiClientFactory clientFactory, IConnectionSettings connectionSettings, 
            ITelemetryReportingService reportingService, string testName)
        {
            _clientFactory = clientFactory;
            _connectionSettings = connectionSettings;
            _reportingService = reportingService;
            _testName = testName;
        }

        public void Dispose()
        {
            try
            {
                _reportingService?.ReportInfo($"Ending test {_testName}", new List<string> {"testend", _testName});

                //logout via the helper
                _currentApiClient?.Logout(_sessionToken);
            }
            catch (Exception e)
            {
                _reportingService?.ReportInfo($"Error while disconnecting from test {_testName}::{e.Message}",
                    new List<string> {"testend", _testName, "logoutfailure"});
            }
        }

        public async Task<IApprendaApiClient> GetClient(ApiPortals portalsToUse)
        {
            if (_currentApiClient == null)
            {
                _currentApiClient = _clientFactory.GetV1Client(portalsToUse);
            }

            if (string.IsNullOrEmpty(_sessionToken))
            {
                _sessionToken = await _currentApiClient.Login(_connectionSettings.UserLogin.UserName, _connectionSettings.UserLogin.Password);
            }

            return _currentApiClient;
        }
    }
}
