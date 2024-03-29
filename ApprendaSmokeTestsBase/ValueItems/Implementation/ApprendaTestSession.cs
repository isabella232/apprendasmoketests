﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaAPIClient.Factories;
using ApprendaAPIClient.Services;
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
        private readonly ITelemetryReportingService _reportingService;
        private readonly string _testName;
        private readonly IUserLogin _login;
        private string _sessionToken;

        public ApprendaTestSession(IApprendaApiClientFactory clientFactory, IConnectionSettings connectionSettings,
            ITelemetryReportingService reportingService, string testName, IUserLogin loginToUse = null)
        {
            _clientFactory = clientFactory;
            ConnectionSettings = connectionSettings;
            _reportingService = reportingService;
            _testName = testName;
            _login = loginToUse ?? connectionSettings.UserLogin;
        }

        public void Dispose()
        {
            try
            {
                _reportingService?.ReportInfo($"Ending test {_testName}", new List<string> { "testend", _testName });

                //logout via the helper
                _currentApiClient?.Logout(_sessionToken);
            }
            catch (Exception e)
            {
                _reportingService?.ReportInfo($"Error while disconnecting from test {_testName}::{e.Message}",
                    new List<string> { "testend", _testName, "logoutfailure" });
            }
        }

        public async Task<IApprendaApiClient> GetClient(ApiPortals portalsToUse)
        {
            if (_currentApiClient == null)
            {
                _currentApiClient = _reportingService == null 
                    ? _clientFactory.GetV1Client() 
                    : _clientFactory.GetV1Client(_reportingService);
            }

            if (string.IsNullOrEmpty(_sessionToken))
            {
                _sessionToken = await _currentApiClient.Login(_login.UserName, _login.Password);
            }

            return _currentApiClient;
        }

        public IConnectionSettings ConnectionSettings { get; }
    }
}
