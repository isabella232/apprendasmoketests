using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.AccountPortal;
using ApprendaAPIClient.Services;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace ApprendaAPIClient
{
    public class ApprendaSwaggerApiClient : IApprendaApiClient
    {
        private readonly string _basePath;
        private readonly SwaggerModelMapperService _modelMapper;

        public ApprendaSwaggerApiClient(string basePath)
        {
            _basePath = basePath;
        }

        public Task PromoteApp(string appAlias)
        {
            throw new NotImplementedException();
        }

        public PagedResourceBase<ApplicationVersionResource> GetAccountApplicationVersions()
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task Logout(string sessionToken)
        {
            throw new NotImplementedException();
        }
    }
}
