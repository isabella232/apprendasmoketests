﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaAPIClient
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
        /// User to login as for this test
        /// </summary>
        IUserLogin UserLogin { get; set; }

        /// <summary>
        /// Data directory for files to retrieve to be used by the test
        /// </summary>
        string IntegrationTestResourcesDirectory { get; }

        string RepositoryServer { get; }

        string AdminTenantAlias { get; }
    }
}
