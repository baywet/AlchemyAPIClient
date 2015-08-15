using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyKeywordsRequestBase : AlchemyRequestBase<AlchemyKeyword, AlchemyKeywordsResponse>, ICombinableAlchemyAPIRequest
    {
        protected const string urlKey = "url";
        private const string maxRetrieveKey = "maxRetrieve";
        private const string sentimentKey = "sentiment";
        private const string showSourceTextKey = "showSourceText";
        private const string knowledgeGraphKey = "knowledgeGraph";
        private const string baseUrlKey = "baseUrl";
        private const string keywordExtractModeKey = "keywordExtractMode";
        protected AlchemyKeywordsRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
        public int MaxRetrieve { get { return GetIntParameter(maxRetrieveKey); } set { AddOrUpdateParameter(maxRetrieveKey, value); } }
        public bool Sentiment { get { return GetBooleanParameter(sentimentKey); } set { AddOrUpdateParameter(sentimentKey, value); } }
        public bool KnowledgeGraph { get { return GetBooleanParameter(knowledgeGraphKey); } set { AddOrUpdateParameter(knowledgeGraphKey, value); } }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public KeyWordExtractModeType KeyWordExtractModeText
        {
            get
            {
                var textValue = GetParameter(keywordExtractModeKey);
                if (string.IsNullOrEmpty(textValue))
                    return KeyWordExtractModeType.Normal;
                else
                    return (KeyWordExtractModeType)Enum.Parse(typeof(KeyWordExtractModeType), textValue);
            }
            set
            {
                AddOrUpdateParameter(keywordExtractModeKey, Enum.GetName(typeof(KeyWordExtractModeType), value));
            }
        }
        public string CallName
        {
            get
            {
                return "keyword";
            }
        }
    }
}
