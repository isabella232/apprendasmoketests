using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaSmokeTestsBase.ValueItems
{
    /// <summary>
    /// All settings that a test requires in order to connect to a Apprenda platform
    /// </summary>
    public interface IConnectionSettings
    {
        /// <summary>
        /// Base url of the platform - apps.apprenda.test
        /// </summary>
        string AppsUrl { get; }
        /// <summary>
        /// Admin user to login as
        /// </summary>
        string AdminUser { get; }
        /// <summary>
        /// Admin password to login as
        /// </summary>
        string AdminPassword { get; }
        /// <summary>
        /// Data directory for files to retrieve to be used by the test
        /// </summary>
        string IntegrationTestResourcesDirectory { get; }

        string RepositoryServer { get; }

        string AdminTenantAlias { get; }
    }
}
