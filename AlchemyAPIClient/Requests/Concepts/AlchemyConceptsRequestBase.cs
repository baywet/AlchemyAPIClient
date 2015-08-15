using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyConceptsRequestBase : AlchemyRequestBase<AlchemyConcept, AlchemyConceptsResponse>
    {
        protected const string maxRetrieveKey = "maxRetrieve";
        protected const string showSourceTextKey = "showSourceText";
        protected const string knowledgeGraphKey = "knowledgeGraph";
        protected const string linkedDataKey = "linkedData";
        protected const string urlKey = "url";
        protected AlchemyConceptsRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public bool KnowledgeGraph { get { return GetBooleanParameter(knowledgeGraphKey); } set { AddOrUpdateParameter(knowledgeGraphKey, value); } }
        public bool LinkedData { get { return GetBooleanParameter(linkedDataKey); } set { AddOrUpdateParameter(linkedDataKey, value); } }
        public int MaxRetrieve { get { return GetIntParameter(maxRetrieveKey); } set { AddOrUpdateParameter(maxRetrieveKey, value); } }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
    }
}
