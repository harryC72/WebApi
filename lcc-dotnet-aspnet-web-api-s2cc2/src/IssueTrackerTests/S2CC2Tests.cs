using IssueTracker;
using IssueTrackerTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace IssueTrackerTests
{
    [Collection("Test Collection")]
    [Trait("Code Challenge", "S2CC2")]
    public class S2CC2Tests : BaseTests
    {
        public S2CC2Tests(AssemblyFixture assemblyFixture)
            : base(assemblyFixture)
        {
        }

        [Fact]
        public void DefaultRouteIsConfigured()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            Assert.True(config.Routes.Count > 0,
                "Did you use the 'WebApiConfig.Register' method's HttpConfiguration 'config' parameter to configure a default route?");

            Assert.True(config.Routes.Count == 1,
                "Are you configuring more than route in the 'WebApiConfig.Register' method? For now, just configure the default route.");

            Assert.True(config.Routes.ContainsKey("DefaultApi"),
                "Did you name your default route 'DefaultApi'?");

            var route = config.Routes["DefaultApi"];

            Assert.True(route.RouteTemplate == "api/{controller}/{id}",
                "Did you use 'api/{controller}/{id}' for your default route's route template?");

            Assert.True(route.Defaults.ContainsKey("id") &&
                route.Defaults["id"].GetType() == typeof(RouteParameter),
                "Did you use an anonymous object to configure the 'id' route template segment to be optional?");
        }
    }
}
