namespace GatewayClient.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using NUnit.Framework;
    using RichardSzalay.MockHttp;

    public class GridStatusSpec
    {
        public static IEnumerable<TestCaseData> GridStatusCalls
        {
            get
            {
                yield return new TestCaseData(@"{""grid_status"":""SystemGridConnected"",""grid_services_active"":false}", new GridStatus {GridServicesActive = false, GridStatusGridStatus = "SystemGridConnected"});
                yield return new TestCaseData(@"{""grid_status"":""SystemGridDisconnected"",""grid_services_active"":false}", new GridStatus {GridServicesActive = false, GridStatusGridStatus = "SystemGridDisconnected"});
                yield return new TestCaseData(@"{""grid_status"":""SystemGridConnected"",""grid_services_active"":true}", new GridStatus {GridServicesActive = true, GridStatusGridStatus = "SystemGridConnected"});
            }
        }
        
        [TestCaseSource("GridStatusCalls")]
        public async Task GridStatusCall(string payload, GridStatus expected)
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp
                .When("http://localhost/api/system_status/grid_status")
                .Respond("application/json", payload);

            var mockClient = mockHttp.ToHttpClient();
            mockClient.BaseAddress = new Uri("http://localhost");
            
            var gatewayClient = new GatewayClient(mockClient);
            var gridStatus = await gatewayClient.GetGridStatus();
            
            Assert.AreEqual(expected.GridServicesActive, gridStatus.GridServicesActive);
            Assert.AreEqual(expected.GridStatusGridStatus, gridStatus.GridStatusGridStatus);
        }
    }
}