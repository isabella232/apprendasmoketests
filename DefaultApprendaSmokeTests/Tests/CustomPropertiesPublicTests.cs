using System.Linq;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.ValueItems;
using Xunit;

namespace DefaultApprendaSmokeTests.Tests
{
    public class CustomPropertiesPublicTests : EasySmokeTest
    {
        [Fact]
        public async Task GetSingleThatDoesNotExist()
        {
            // Verifies proper behavior of APPRENDA-22264
            using (var session = StartSession())
            {
                var id = 999999;
                var client = await session.GetClient(ApiPortals.SOC);

                var res = await client.GetCustomProperty(id);
                Assert.Null(res);
            }
        }

        [Fact]
        public async Task GetManyAndThenById()
        {
            using (var session = StartSession())
            {
                //Assemble
                var client = await session.GetClient(ApiPortals.SOC);

                //ACT
                var res = await client.GetAllCustomProperties();

                //ASSERT
                Assert.True(res.Items.Count() < 10);
                Assert.Equal(10, res.PageSize);
                Assert.Equal(1, res.CurrentPage);
                Assert.True(res.TotalPages > 0);

                var first = res.Items.First();

                var id = first.Id;

                var singleRes = await client.GetCustomProperty(id);

                Assert.NotNull(singleRes);
                Assert.NotNull(singleRes.ValueOptions.PossibleValues);
            }
        }

        /*
        [Fact]
        public async Task TestEndToEnd()
        {
            // This test is also consumed by the ExportAuditLogTests to ensure there are audit log entries to export.
            using (var session = StartSession())
            {
                var created = CreateCustomProperty(session);
                var id = created.Id;
                SearchCustomProperties(session, id);
                await UpdateCustomProperty(session, id);
                await DeleteCustomProperty(session, id);
            }
        }

        private void SearchCustomProperties(SessionStartInfo session, int id)
        {
            //Assemble
            var uri = new ClientUriBuilder(session.Helper.ApiRoot).BuildUri("customproperties", null, new { appliedTo = "Applications", pageSize = 200, pageNumber = 1 });
            var client = GetClient(uri, session.SessionToken);

            //ACT
            var res = client.Get<PagedResourceBase<CustomPropertyResource>>();

            //ASSERT
            Assert.NotNull(res);
            Assert.True(res.Items.Any(x => x.Id == id));
        }

        private async Task UpdateCustomProperty(SessionStartInfo session, int id)
        {
            var individUri = new ClientUriBuilder(session.Helper.ApiRoot).BuildUri("customproperties/{0}", new object[] { id });
            var individClient = GetClient(individUri, session.SessionToken);

            var updatable = individClient.Get<CustomPropertyUpdateResource>();
            updatable.ValueOptions.DefaultValues.Remove("three");
            updatable.ValueOptions.PossibleValues.Remove("three");
            updatable.ValueOptions.PossibleValues.Add("five");
            updatable.DeletedValueReplacements = new Dictionary<string, string>
            {
                { "three", "five" }
            };

            updatable.Applicability.Applications = null;
            updatable.DeveloperOptions = null;

            var putresult = await individClient.PutAsync(individUri.AbsoluteUri, new JsonHttpContent(updatable));
            Assert.AreEqual(HttpStatusCode.NoContent, putresult.StatusCode);

            var cprop = individClient.Get<CustomPropertyResource>();
            Assert.IsNull(cprop.Applicability.Applications);
            Assert.False(cprop.DeveloperOptions.IsVisible);
            Assert.False(cprop.DeveloperOptions.VisibilityOptions.IsEditableByDeveloper);
            Assert.False(cprop.DeveloperOptions.VisibilityOptions.IsRequiredForDeployment);
            Assert.Contains("five", cprop.ValueOptions.PossibleValues);
            Assert.False(cprop.ValueOptions.DefaultValues.Contains("three"));
            Assert.False(cprop.ValueOptions.PossibleValues.Contains("three"));
        }

        private async Task DeleteCustomProperty(SessionStartInfo session, int id)
        {
            var individUri = new ClientUriBuilder(session.Helper.ApiRoot).BuildUri("customproperties/{0}", new object[] { id });
            var individClient = GetClient(individUri, session.SessionToken);

            var deletion = await individClient.DeleteAsync(individUri);
            Assert.AreEqual(HttpStatusCode.NoContent, deletion.StatusCode);
        }


        private CustomPropertyResource CreateCustomProperty(SessionStartInfo session)
        {
            return CreateAndGetCustomProperty(session.Helper.ApiRoot, session.SessionToken, (uri, token) => GetClient(uri, token));
        }

        internal static CustomPropertyResource CreateAndGetCustomProperty(UriBuilder apiRoot, string sessionToken, Func<Uri, string, HttpClient> clientFunc)
        {
            // Assemble
            var uri = new ClientUriBuilder(apiRoot).BuildUri("customproperties");
            var client = clientFunc(uri, sessionToken);

            var suffix = new Random().Next(10000);

            var customProperty = new CustomPropertyResource
            {
                Name = $"test{suffix}",
                DisplayName = $"Testing {suffix}",
                Applicability = new CustomPropertyApplicabilityOptionCollection
                {
                    Applications = new CustomPropertyApplicationOptions
                    {
                        AllowMultipleValues = true,
                        IsApplied = true,
                        IsComponentLevel = false,
                        ApplicationComponentLevelOptions = new CustomPropertyApplicationComponentOptions
                        {
                            Databases = true,
                            JavaWebApplications = true,
                            LinuxServices = true,
                            UserInterfaces = true,
                            WindowsServices = true
                        }
                    },
                    ComputeServers = new CustomPropertyApplicabilityOption
                    {
                        IsApplied = true,
                        AllowMultipleValues = true,
                    },
                    DatabaseServers = new CustomPropertyApplicabilityOption
                    {
                        IsApplied = true,
                        AllowMultipleValues = true,
                    },
                    ResourcePolicies = new CustomPropertyApplicabilityOption
                    {
                        IsApplied = true,
                        AllowMultipleValues = true
                    },
                    StorageQuotas = new CustomPropertyApplicabilityOption
                    {
                        IsApplied = true,
                        AllowMultipleValues = true
                    }
                },
                DeveloperOptions = new CustomPropertyDeveloperOptions
                {
                    IsVisible = true,
                    VisibilityOptions = new VisibilityOptions
                    {
                        IsEditableByDeveloper = true,
                        IsRequiredForDeployment = true
                    }
                },
                ValueOptions = new CustomPropertyValueOptions
                {
                    AllowCustomValues = true,
                    PossibleValues = new List<string> { "one", "two", "three" },
                    DefaultValues = new List<string> { "two", "three" }
                }
            };

            // Act
            var responseProperty =
                client.PostWithResponse<CustomPropertyResource, CustomPropertyResource>(customProperty);

            // Assert
            Assert.AreEqual(customProperty.Name, responseProperty.Name);
            Assert.AreNotEqual(0, responseProperty.Id);
            return responseProperty;
        }*/
    }
}
