using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.AccountPortal;
using IO.Swagger.Model;
using ApplicationVersion = IO.Swagger.Model.ApplicationVersion;

namespace ApprendaAPIClient.Services
{
    /// <summary>
    /// Basic class that lets us expose more friendly names than the C# generated ones.  Swagger C# gen sucks
    /// </summary>
    internal class SwaggerModelMapperService
    {
        public PagedResourceBase<ApplicationVersion> MapFromInlineResponse(InlineResponse200 source)
        {
            throw new NotImplementedException();
        }

        public ApplicationVersion Map(InlineResponse2002Items source)
        {
            throw new NotImplementedException();
        }
    }
}
