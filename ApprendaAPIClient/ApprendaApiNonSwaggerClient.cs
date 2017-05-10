using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.AccountPortal;
using ApprendaAPIClient.Services;
using ApprendaAPIClient.Services.ClientHelpers;
using ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers;
using RESTApiTests.Account.Resources;

namespace ApprendaAPIClient
{
    public class ApprendaApiNonSwaggerClient : IApprendaApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _appsRoot;
        private string _sessionToken;

        private readonly IConnectionSettings _connectionSettings;
        private string DevRoot => _appsRoot + "/developer";
        private string AccountRoot => _appsRoot + "/account";
        private string SOCRoot => _appsRoot + "/soc";

        public ApprendaApiNonSwaggerClient(HttpClient httpClient, IConnectionSettings connectionSettings)
        {
            _httpClient = httpClient;
            _connectionSettings = connectionSettings;
            _appsRoot = connectionSettings.AppsUrl;
            _sessionToken = null;
        }

        public PagedResourceBase<ApplicationVersionResource> GetAccountApplicationVersions()
        {
            var helper = new AccountApiHelper(_connectionSettings);
            var uri = new ClientUriBuilder(helper.ApiRoot).BuildUri("applicationversions", null, new { pageSize = 200, pageNumber = 1 });

            //Act
            var apps = _httpClient.Get<PagedResourceBase<ApplicationVersionResource>>();

            return apps;
        }

        public Task PromoteApp(string appAlias)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(_sessionToken))
            {
                var helper = new GenericApiHelper(_connectionSettings, "developer");
                _sessionToken = helper?.Authenticator?.Login(userName, password);
            }

            return Task.FromResult(_sessionToken);
        }

        public Task Logout(string sessionToken)
        {
            var helper = new GenericApiHelper(_connectionSettings, "developer");
            helper?.Authenticator.Logout(_sessionToken);
            _sessionToken = null;

            return Task.FromResult(false);
        }
    }
}
