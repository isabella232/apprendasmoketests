using System;
using System.Collections.Generic;
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

        public IApprendaApiClient GetClient(ApiPortals portalsToUse)
        {
            switch (portalsToUse)
            {
                    case ApiPortals.Account:
                        _currentHelper = new AccountApiHelper(_connectionSettings);
                        break;
                    case ApiPortals.Developer:
                        _currentHelper = new GenericApiHelper(_connectionSettings, "developer");
                        break;
                    case ApiPortals.SOC:
                        _currentHelper = new SocApiHelper(_connectionSettings);
                        break;
            }

            if (string.IsNullOrEmpty(_sessionToken))
            {
                _sessionToken = _currentHelper.Authenticator?.Login(_connectionSettings.UserLogin.UserName,
                    _connectionSettings.UserLogin.Password);
            }
            _client = _clientFactory.GetV1Client(portalsToUse);

            _reportingService?.ReportInfo($"Starting test {_testName}", new List<string> {"teststart", _testName});
            return _client;
        }
    }
}
