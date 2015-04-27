using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyKeywordsRequestBase : AlchemyRequestBase<AlchemyKeyword, AlchemyKeywordsResponse>
    {
        protected const string urlKey = "url";
        protected const string maxRetrieveKey = "maxRetrieve";
        protected const string sentimentKey = "sentiment";
        protected const string showSourceTextKey = "showSourceText";
        protected const string knowledgeGraphKey = "knowledgeGraph";
        protected const string baseUrlKey = "baseUrl";
        protected const string keywordExtractModeKey = "keywordExtractMode";
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
    }
}
