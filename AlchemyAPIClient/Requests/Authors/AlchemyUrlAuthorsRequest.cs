﻿using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlAuthorsRequest: AlchemyAuthorsRequestBase, IAlchemyAPIUrlRequest
    {
        public AlchemyUrlAuthorsRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetAuthors"; }
        }
    }
}
