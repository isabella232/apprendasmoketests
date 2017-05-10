using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaAPIClient.Services.ClientHelpers;
using ApprendaSmokeTestsBase.Factories;
using ApprendaSmokeTestsBase.Services;
using ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers;

namespace ApprendaSmokeTestsBase.ValueItems.Implementation
{
    /// <summary>
    /// Holds authentication info, and exposes a client via it
    /// </summary>
    internal class ApprendaTestSession : IApprendaTestSession
    {
        private readonly IApprendaApiClientFactory _clientFactory;
        private readonly IConnectionSettings _connectionSettings;
        private readonly ITelemetryReportingService _reportingService;
        private readonly string _testName;

        private IApprendaApiClient _client;
        private string _sessionToken;
        private IRestApiClientHelper _currentHelper;

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
                _currentHelper?.Authenticator?.Logout(_sessionToken);
            }
            catch (Exception e)
            {
                _reportingService?.ReportInfo($"Error while disconnecting from test {_testName}",
                    new List<string> {"testend", _testName, "logoutfailure"});
            }
        }

        public async Task<IApprendaApiClient> GetClient(ApiPortals portalsToUse)
        {
            var client = _clientFactory.GetV1Client(portalsToUse);

            if (string.IsNullOrEmpty(_sessionToken))
            {
                _sessionToken = await client.Login(_connectionSettings.UserLogin.UserName, _connectionSettings.UserLogin.Password);
            }

            _reportingService?.ReportInfo($"Starting test {_testName}", new List<string> {"teststart", _testName});
            return _client;
        }
    }
}
