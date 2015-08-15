using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyHtmlTaxonomiesRequestBase : AlchemyTaxonomiesRequestBase, ICombinableAlchemyAPIRequest
    {
        private const string sourceTextKey = "sourceText";
        private const string cqueryKey = "cquery";
        private const string xpathKey = "xpath";
        public AlchemyHtmlTaxonomiesRequestBase(AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
        }
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
