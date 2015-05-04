using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyRelationsRequestBase : AlchemyRequestBase<AlchemyRelation, AlchemyRelationsResponse>
    {
        protected const string urlKey = "url";
        protected const string maxRetrieveKey = "maxRetrieve";
        protected const string sentimentKey = "sentiment";
        protected const string entitiesKey = "entities";
        protected const string keywordsKey = "keywords";
        protected const string requireEntitiesKey = "requireEntities";
        protected const string sentimentExcludeEntitiesKey = "sentimentExcludeEntities";
        protected const string disambiguateKey = "disambiguate";
        protected const string linkedDataKey = "linkedData";
        protected const string coreferenceKey = "coreference";
        protected const string showSourceTextKey = "showSourceText";
        protected const string sourceTextKey = "sourceText";
        protected const string cqueryKey = "cquery";
        protected const string xpathKey = "xpath";
        protected const string baseUrlKey = "baseUrl";
        public AlchemyRelationsRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
        public int MaxRetrieve { get { return GetIntParameter(maxRetrieveKey); } set { AddOrUpdateParameter(maxRetrieveKey, value); } }
        public bool Disambiguate { get { return GetBooleanParameter(disambiguateKey); } set { AddOrUpdateParameter(disambiguateKey, value); } }
        public bool LinkedData { get { return GetBooleanParameter(linkedDataKey); } set { AddOrUpdateParameter(linkedDataKey, value); } }
        public bool Coreference { get { return GetBooleanParameter(coreferenceKey); } set { AddOrUpdateParameter(coreferenceKey, value); } }
        public bool Sentiment { get { return GetBooleanParameter(sentimentKey); } set { AddOrUpdateParameter(sentimentKey, value); } }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public bool Entities { get { return GetBooleanParameter(entitiesKey); } set { AddOrUpdateParameter(entitiesKey, value); } }
        public bool Keywords { get { return GetBooleanParameter(keywordsKey); } set { AddOrUpdateParameter(keywordsKey, value); } }
        public bool RequireEntities { get { return GetBooleanParameter(requireEntitiesKey); } set { AddOrUpdateParameter(requireEntitiesKey, value); } }
        public bool SentimentExcludeEntitiesKey { get { return GetBooleanParameter(sentimentExcludeEntitiesKey); } set { AddOrUpdateParameter(sentimentExcludeEntitiesKey, value); } }
        public bool Cquery { get { return GetBooleanParameter(cqueryKey); } set { AddOrUpdateParameter(cqueryKey, value); } }
        public bool Xpath { get { return GetBooleanParameter(xpathKey); } set { AddOrUpdateParameter(xpathKey, value); } }
        public SourceTextType SourceText
        {
            get
            {
                var textValue = GetParameter(sourceTextKey);
                if (string.IsNullOrEmpty(textValue))
                    return SourceTextType.cleaned_or_raw;
                else
                    return (SourceTextType)Enum.Parse(typeof(SourceTextType), textValue);
            }
            set
            {
                AddOrUpdateParameter(sourceTextKey, Enum.GetName(typeof(SourceTextType), value));
            }
        }

    }
}
