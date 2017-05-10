using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private IApprendaApiClient _client;
        private readonly IDictionary<ApiPortals, LoggedInPortalAndHelper> _helpersInUse;

        private class LoggedInPortalAndHelper
        {
            public ApiPortals Portal;
            public string Token;
            public IRestApiClientHelper Helper;
        }
        public ApprendaTestSession(IApprendaApiClientFactory clientFactory, IConnectionSettings connectionSettings)
        {
            _clientFactory = clientFactory;
            _connectionSettings = connectionSettings;
            _helpersInUse = new ConcurrentDictionary<ApiPortals, LoggedInPortalAndHelper>();
        }

        public void Dispose()
        {
            //logout via the helper
            foreach (var bundle in _helpersInUse.Values)
            {
                bundle.Helper?.Authenticator?.Logout(bundle.Token);
            }
        }

        public IApprendaApiClient GetClient(ApiPortals portalsToUse)
        {
            _client = _clientFactory.GetV1Client(portalsToUse);

            //login and get authentication helpers here or in the constructor?
            LogInPortalAndHelper(portalsToUse);

            return _client;
        }

        private void LogInPortalAndHelper(ApiPortals portal)
        {
            if (!_helpersInUse.ContainsKey(portal))
            {
                IRestApiClientHelper helper = null;
                switch (portal)
                {
                        case ApiPortals.Account:
                        case ApiPortals.Developer:
                        case ApiPortals.SOC:
                            helper = new SocApiHelper(_connectionSettings);
                            break;
                    default:
                        throw new ArgumentException();
                }

                var token = helper.Authenticator.Login(_connectionSettings.UserLogin.UserName, _connectionSettings.UserLogin.Password);

                _helpersInUse.Add(portal, new LoggedInPortalAndHelper
                    {
                        Helper = helper,
                        Portal =  portal,
                        Token = token
                    }
                    );
            }
        }
    }
}
