using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using Cloud = ApprendaAPIClient.Models.AccountPortal.Cloud;

namespace ApprendaAPIClient.Clients
{
    public interface IApprendaAccountPortalApiClient
    {
        Task<UnpagedResourceBase<Cloud>> GetClouds();

        Task<Cloud> GetCloud(int id);
    }
}
