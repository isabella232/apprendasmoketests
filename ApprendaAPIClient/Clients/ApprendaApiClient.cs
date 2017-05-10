using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ApprendaAPIClient.Services;
using ApprendaAPIClient.Services.ClientHelpers;
using IO.Swagger.Model;
using Newtonsoft.Json;
using Application = ApprendaAPIClient.Models.DeveloperPortal.Application;
using Version = IO.Swagger.Model.Version;

namespace ApprendaAPIClient.Clients
{
    internal class ApprendaApiClient : BaseApprendaApiClient, IApprendaApiClient
    {
        protected string DevRoot => AppsRoot + "/developer";
        protected string AccountRoot => AppsRoot + "/account";
        protected string SOCRoot => AppsRoot + "/soc";

        private ITelemetryReportingService _reportingService;
        public ApprendaApiClient(IConnectionSettings connectionSettings)
            : base(connectionSettings)
        {
        }

        public Task PromoteApp(string appAlias)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Application>> GetApplications()
        {
            return GetResultAsync<IEnumerable<Application>>("apps");
        }

        public Task<EnrichedApplication> GetApplication(string appAlias)
        {
            return GetResultAsync<EnrichedApplication>("apps/" + appAlias);
        }

        public Task<IEnumerable<Version>> GetVersionsForApplication(string appAlias)
        {
            return GetResultAsync<IEnumerable<Version>>("versions/" + appAlias);
        }

        public Task<EnrichedVersion> GetVersion(string appAlias, string versionAlias)
        {
            return GetResultAsync<EnrichedVersion>("versions/" + appAlias + "/" + versionAlias);
        }

        protected virtual async Task<T> GetResultAsync<T>(string path, string helperType = "developer", [CallerMemberName] string callingMethod = "")
        {
            var helper = new GenericApiHelper(ConnectionSettings, helperType);
            var uri = new ClientUriBuilder(helper.ApiRoot).BuildUri(path);
            var client = GetClient(uri, SessionToken);

            var res = await client.GetStringAsync(uri);

            return JsonConvert.DeserializeObject<T>(res);
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
