﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using IO.Swagger.Model;
using Application = ApprendaAPIClient.Models.DeveloperPortal.Application;
using Version = IO.Swagger.Model.Version;

namespace ApprendaAPIClient
{
    public interface IApprendaDeveloperPortalApiClient
    {
        Task PromoteApp(string appAlias);

        Task<IEnumerable<Application>> GetApplications();

        Task<EnrichedApplication> GetApplication(string appAlias);

        Task<bool> PostApp(Application app);

        Task<bool> DeleteApplication(string appAlias);

        Task<IEnumerable<Version>> GetVersionsForApplication(string appAlias);

        Task<EnrichedVersion> GetVersion(string appAlias, string versionAlias);
    }
}
