using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Model;

namespace ApprendaSmokeTestsBase.Services
{
    /// <summary>
    /// Represents a client which can talk to the apprenda platform for the duration of a test
    /// Returns items from the Apprenda API defined by pregenned swagger, definitions are to be found there
    /// </summary>
    public interface IApprendaApiClient
    {
        Task<Application> GetApplication(string appAlias);
        Task<IEnumerable<Application>> GetAllApplications();

        Task PromoteApp(string appAlias);
    }
}
