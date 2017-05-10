using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace ApprendaSmokeTestsBase.Services.Implementation
{
    internal class ApprendaSwaggerApiClient : IApprendaApiClient
    {
        private readonly string _basePath;
        public ApprendaSwaggerApiClient(string basePath)
        {
            
        }

        public async Task<Application> GetApplication(string appAlias)
        {
            //use the API luke
            var api = new AppsApi(_basePath);
            var res = await api.AppsGetAsync(appAlias);

            if (res != null)
            {
                //TODO fix return type or mapping from the API!
                return new Application
                {
                    Alias = res.Alias
                };
            }

            return null;
        }

        public Task<IEnumerable<Application>> GetAllApplications()
        {
            var api = new AppsApi(_basePath);
            throw new NotImplementedException();
        }

        public Task PromoteApp(string appAlias)
        {
            throw new NotImplementedException();
        }
    }
}
