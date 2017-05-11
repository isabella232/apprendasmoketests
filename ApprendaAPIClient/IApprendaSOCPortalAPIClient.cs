using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.SOC;
using IO.Swagger.Model;

namespace ApprendaAPIClient
{
    public interface IApprendaSOCPortalAPIClient
    {
        Task<IEnumerable<Host>> GetAllHosts();

        Task<PagedResourceBase<HealthReport>> GetHealthReports(string hostName);
    }
}
