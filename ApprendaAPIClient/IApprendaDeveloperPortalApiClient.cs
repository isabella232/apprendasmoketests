using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaAPIClient
{
    public interface IApprendaDeveloperPortalApiClient
    {
        Task PromoteApp(string appAlias);
    }
}
