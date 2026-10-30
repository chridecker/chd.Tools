using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using chd.Api.Base.Client;
using Microsoft.Extensions.Logging;

namespace chd.Tools.HttpClientConsole
{
    public class PSSClient(ILogger<BaseApiService> logger, IHttpClientFactory httpClientFactory)
        : BaseApiService(logger, httpClientFactory)
    {
        public Task PostAsync<T>(string uri, T dto, CancellationToken cancellationToken) => base.Post(uri, dto, cancellationToken);

    }

}
