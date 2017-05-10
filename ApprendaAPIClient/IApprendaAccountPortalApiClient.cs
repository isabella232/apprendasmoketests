using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.AccountPortal;
using IO.Swagger.Model;

namespace ApprendaAPIClient
{
    public interface IApprendaAccountPortalApiClient
    {
        PagedResourceBase<ApplicationVersionResource> GetAccountApplicationVersions();
    }
}
