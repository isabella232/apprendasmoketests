using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using IO.Swagger.Model;
using Application = ApprendaAPIClient.Models.DeveloperPortal.Application;

namespace ApprendaAPIClient
{
    public interface IApprendaDeveloperPortalApiClient
    {
        Task PromoteApp(string appAlias);

        Task<IEnumerable<Application>> GetApplications();
    }
}
