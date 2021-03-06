﻿using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlAuthorRequest : AlchemyAuthorRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        public AlchemyUrlAuthorRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetAuthor"; }
        }
    }
}
