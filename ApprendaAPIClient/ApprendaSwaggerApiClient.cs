using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.AccountPortal;
using ApprendaAPIClient.Services;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Application = ApprendaAPIClient.Models.DeveloperPortal.Application;

namespace ApprendaAPIClient
{
    public class ApprendaSwaggerApiClient : BaseApprendaApiClient, IApprendaApiClient
    {
        private readonly SwaggerModelMapperService _modelMapper;

        protected string DevRoot => AppsRoot + "/developer/api/v1";
        protected string AccountRoot => AppsRoot + "/account/api/v1";
        protected string SOCRoot => AppsRoot + "/soc/api/v1";

        public ApprendaSwaggerApiClient(IConnectionSettings connectionSettings)
            : base(connectionSettings)
        {
            _modelMapper = new SwaggerModelMapperService();
        }

        public Task PromoteApp(string appAlias)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Application>> GetApplications()
        {
            throw new NotImplementedException();
        }
    }
}
