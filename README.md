# GatewayClient
A simple httpclient implementation of the Tesla Gateway 2 api. Based off the work Vince Loschiavo(@vloschiavo) did over at https://github.com/vloschiavo/powerwall2

# Install
    dotnet add package GatewayClient

# Usage

## ASP.NET Core
    .ConfigureServices((context, services) =>
                {
                    services
                        .AddHttpClient("GatewayClient", client =>
                        {
                            client.BaseAddress = new Uri("https://localhost"); // Base url for gateway web uri
                            client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-GatewayClient");
                        })
                        .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                        {
                            ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true // Ignore self signed cert
                        })
                        .AddTypedClient<GatewayClient>();
                });
    