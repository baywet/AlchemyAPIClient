﻿using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyTitleRequestBase : AlchemyRequestBase<string, AlchemyTitleResponse>
    {
        protected const string urlKey = "url";
        protected const string useMetadataKey = "useMetadata";
        public AlchemyTitleRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public bool UseMetadata { get { return GetBooleanParameter(useMetadataKey); } set { AddOrUpdateParameter(useMetadataKey, value); } }
    }
}
