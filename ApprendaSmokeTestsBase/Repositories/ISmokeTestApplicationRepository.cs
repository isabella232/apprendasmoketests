using System.Threading.Tasks;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Repositories
{
    public interface ISmokeTestApplicationRepository
    {
        Task<ISmokeTestApplication> GetSmokeTestApplication(string smokeTestApplicationName);
    }
}
