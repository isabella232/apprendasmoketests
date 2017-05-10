using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Services;
using ApprendaAPIClient.Services.ClientHelpers;
using ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers;
using IO.Swagger.Model;
using Newtonsoft.Json;
using Application = ApprendaAPIClient.Models.DeveloperPortal.Application;

namespace ApprendaAPIClient
{
    public class ApprendaApiNonSwaggerClient : BaseApprendaApiClient, IApprendaApiClient
    {
        protected string DevRoot => AppsRoot + "/developer";
        protected string AccountRoot => AppsRoot + "/account";
        protected string SOCRoot => AppsRoot + "/soc";

        public ApprendaApiNonSwaggerClient(IConnectionSettings connectionSettings)
            : base(connectionSettings)
        {
        }

        public Task PromoteApp(string appAlias)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Application>> GetApplications()
        {
            var helper = new GenericApiHelper(ConnectionSettings, "developer");
            var uri = new ClientUriBuilder(helper.ApiRoot).BuildUri("apps", null, null);

            var client = GetClient(uri, SessionToken);

            //var res = client.Get<IEnumerable<Application>>();
            var res = await client.GetStringAsync(uri);

            var deser = JsonConvert.DeserializeObject<IEnumerable<Application>>(res);
            return deser;
        }

        private HttpClient GetClient(Uri baseAddress, string authenticationToken = null, TimeSpan? timeout = null, string mediaType = null)
        {
            var client = RestApiProxyBase.GetVerbMaintainingClient();
            InitializeHttpClient(baseAddress, authenticationToken, timeout, mediaType, client);
            return client;
        }

        private static void InitializeHttpClient(Uri baseAddress, string authenticationToken, TimeSpan? timeout, string mediaType, HttpClient client)
        {
            client.BaseAddress = baseAddress;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType ?? "application/json"));

            if (!string.IsNullOrWhiteSpace(authenticationToken))
            {
                client.DefaultRequestHeaders.Add(RestAuthenticator.HeaderName, authenticationToken);
            }

            if (timeout.HasValue)
            {
                client.Timeout = timeout.Value;
            }
        }
    }
}
