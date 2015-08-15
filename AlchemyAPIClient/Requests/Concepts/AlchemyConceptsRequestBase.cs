using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyConceptsRequestBase : AlchemyRequestBase<AlchemyConcept, AlchemyConceptsResponse>, ICombinableAlchemyAPIRequest
    {
        private const string maxRetrieveKey = "maxRetrieve";
        private const string showSourceTextKey = "showSourceText";
        private const string knowledgeGraphKey = "knowledgeGraph";
        private const string linkedDataKey = "linkedData";
        protected const string urlKey = "url";
        protected AlchemyConceptsRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public bool KnowledgeGraph { get { return GetBooleanParameter(knowledgeGraphKey); } set { AddOrUpdateParameter(knowledgeGraphKey, value); } }
        public bool LinkedData { get { return GetBooleanParameter(linkedDataKey); } set { AddOrUpdateParameter(linkedDataKey, value); } }
        public int MaxRetrieve { get { return GetIntParameter(maxRetrieveKey); } set { AddOrUpdateParameter(maxRetrieveKey, value); } }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public string CallName
        {
            get
            {
                return "concept";
            }
        }
    }
}
