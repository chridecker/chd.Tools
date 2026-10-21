using System;
using System.Collections.Generic;
using System.Text;
using chd.Api.Base.Contracts.Interfaces;

namespace chd.Tools.HttpClientConsole
{
    public class ApiKeyProvider : IApiKeyProvider
    {
        public string GetApiKey() => "ApiKeyTest";
    }
}
