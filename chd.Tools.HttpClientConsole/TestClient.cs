using System;
using System.Collections.Generic;
using System.Text;
using chd.Api.Base.Client;
using chd.Api.Base.Client.Extensions;
using chd.Api.Base.Contracts.Interfaces;
using Microsoft.Extensions.Logging;

namespace chd.Tools.HttpClientConsole
{
    public class TestClient(
        ILogger<BaseApiService> logger,
        IApiKeyProvider apiKeyProvider,
        IHttpClientFactory httpClientFactory)
        : BaseAuthenticationApiService(logger, apiKeyProvider, httpClientFactory)
    {

        public Task<List<ResponseDto>> GetAsync(CancellationToken cancellationToken)
            => base.Get<List<ResponseDto>>("moresub".SetUrlParameters(("p1", "v1")), cancellationToken);
        
        public Task PostAsync(CancellationToken cancellationToken)
            => base.Post("moresub",new RequestDto(), cancellationToken);
    }
}
