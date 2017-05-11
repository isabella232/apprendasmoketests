using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.SOC;

namespace ApprendaAPIClient
{
    public interface IApprendaSOCPortalAPIClient
    {
        Task<IEnumerable<Host>> GetAllHosts();

        Task<PagedResourceBase<HealthReport>> GetHealthReports(string hostName);
    }
}
