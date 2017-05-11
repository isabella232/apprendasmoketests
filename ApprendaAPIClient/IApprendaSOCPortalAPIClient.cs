using System.Collections.Generic;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.SOC;
using IO.Swagger.Model;
using Cloud = ApprendaAPIClient.Models.SOC.Cloud;
using CustomProperty = ApprendaAPIClient.Models.SOC.CustomProperty;

namespace ApprendaAPIClient
{
    public interface IApprendaSOCPortalAPIClient
    {
        Task<IEnumerable<Host>> GetAllHosts();

        Task<UnpagedResourceBase<Cloud>> GetClouds();

        Task<Cloud> GetCloud(int id);

        Task<PagedResourceBase<HealthReport>> GetHealthReports(string hostName);

        Task<PagedResourceBase<CustomProperty>> GetAllCustomProperties();
        Task<CustomProperty> GetCustomProperty(int id);
    }
}
