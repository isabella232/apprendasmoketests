using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private IApprendaApiClient _client;

        public ApprendaTestSession(IApprendaApiClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public void Dispose()
        {
            //logout via the helper
        }

        public IApprendaApiClient GetClient(ApiPortals portalsToUse = ApiPortals.All)
        {
            _client = _clientFactory.GetV1Client(portalsToUse);

            //login and get authentication helpers here or in the constructor?
            return _client;
        }
    }
}
