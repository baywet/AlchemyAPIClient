﻿using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlLanguageRequest : AlchemyHtmlLanguageRequestBase, IAlchemyAPIUrlRequest
    {
        public AlchemyUrlLanguageRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetLanguage"; }
        }
    }
}
