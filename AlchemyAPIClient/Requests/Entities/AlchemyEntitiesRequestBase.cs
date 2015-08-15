using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyEntitiesRequestBase : AlchemyRequestBase<AlchemyEntity, AlchemyEntitiesResponse>, ICombinableAlchemyAPIRequest
    {
        private const string disambiguateKey = "disambiguate";
        private const string linkedDataKey = "linkedData";
        private const string coreferenceKey = "coreference";
        private const string quotationsKey = "quotations";
        private const string sentimentKey = "sentiment";
        private const string showSourceTextKey = "showSourceText";
        private const string knowledgeGraphKey = "knowledgeGraph";
        private const string structuredEntitiesKey = "structuredEntities";
        private const string maxRetrieveKey = "maxRetrieve";
        private const string baseUrlKey = "baseUrl";
        protected const string urlKey = "url";
        protected AlchemyEntitiesRequestBase(AlchemyClient client)
            : base(client)
        {
            
        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
        public int MaxRetrieve { get { return GetIntParameter(maxRetrieveKey); } set { AddOrUpdateParameter(maxRetrieveKey, value); } }
        public bool Disambiguate { get { return GetBooleanParameter(disambiguateKey); } set { AddOrUpdateParameter(disambiguateKey, value); } }
        public bool LinkedData { get { return GetBooleanParameter(linkedDataKey); } set { AddOrUpdateParameter(linkedDataKey, value); } }
        public bool Coreference { get { return GetBooleanParameter(coreferenceKey); } set { AddOrUpdateParameter(coreferenceKey, value); } }
        public bool Quotations { get { return GetBooleanParameter(quotationsKey); } set { AddOrUpdateParameter(quotationsKey, value); } }
        public bool Sentiment { get { return GetBooleanParameter(sentimentKey); } set { AddOrUpdateParameter(sentimentKey, value); } }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public bool KnowledgeGraph { get { return GetBooleanParameter(knowledgeGraphKey); } set { AddOrUpdateParameter(knowledgeGraphKey, value); } }
        public bool StructuredEntities { get { return GetBooleanParameter(structuredEntitiesKey); } set { AddOrUpdateParameter(structuredEntitiesKey, value); } }
        public string CallName
        {
            get
            {
                return "entity";
            }
        }
    }
}
