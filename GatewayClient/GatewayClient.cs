namespace GatewayClient
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Models;

    public class GatewayClient
    {
        private HttpClient Client { get; }
        private JsonSerializerOptions JsonOptions {get;}
        
        /// <summary>
        /// Constructs a new GatewayClient that allows reading data from a Tesla Gateway 1/2.
        /// Note: HttpClient.BaseAddress must be set
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="convertDateTimeToUTC">Whether to convert read date time values from gateway api to UTC</param>
        public GatewayClient(HttpClient client, bool convertDateTimeToUTC = true)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client), "Must be valid HttpClient instance");

            JsonOptions = convertDateTimeToUTC 
                ? new JsonSerializerOptions {Converters = {new JsonDateTimeConverter()}} 
                : new JsonSerializerOptions();
        }

        private async Task<Stream> GetResponseContentStream(HttpMethod verb, string requestUri)
        {
            // Call given request uri and return stream of data
            var request = new HttpRequestMessage(verb, requestUri);
            var response = await Client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStreamAsync();
        }

        public async Task<Aggregate> GetAggregates()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/meters/aggregates");
            return await JsonSerializer.DeserializeAsync<Aggregate>(contentStream, JsonOptions);
        }
        
        public async Task<SiteSpecificMeterInformation> GetSiteSpecificMeterInformation()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/meters/site");
            return await JsonSerializer.DeserializeAsync<SiteSpecificMeterInformation>(contentStream, JsonOptions);
        }
        
        public async Task<SolarInformation> GetSolarInformation()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/meters/solar");
            return await JsonSerializer.DeserializeAsync<SolarInformation>(contentStream, JsonOptions);
        }
        
        public async Task<SystemStatus> GetSystemStatusState()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/system_status/soe");
            return await JsonSerializer.DeserializeAsync<SystemStatus>(contentStream, JsonOptions);
        }
        
        public async Task<SiteMaster> GetSiteMaster()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/sitemaster");
            return await JsonSerializer.DeserializeAsync<SiteMaster>(contentStream, JsonOptions);
        }
        
        public async Task<PowerwallInformation> GetPowerwallInformation()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/powerwalls");
            return await JsonSerializer.DeserializeAsync<PowerwallInformation>(contentStream, JsonOptions);
        }
        
        public async Task<RegistrationInformation> GetRegistrationInformation()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/customer/registration");
            return await JsonSerializer.DeserializeAsync<RegistrationInformation>(contentStream, JsonOptions);
        }
        
        public async Task<GridStatus> GetGridStatus()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/system_status/grid_status");
            return await JsonSerializer.DeserializeAsync<GridStatus>(contentStream, JsonOptions);
        }

        public async Task<SiteInformation> GetSiteInformation()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/site_info");
            return await JsonSerializer.DeserializeAsync<SiteInformation>(contentStream, JsonOptions);
        }
        
        public async Task<SiteName> GetSiteName()
        {
            var contentStream = await GetResponseContentStream(HttpMethod.Get, "/api/site_info/site_name");
            return await JsonSerializer.DeserializeAsync<SiteName>(contentStream, JsonOptions);
        }
    }
}