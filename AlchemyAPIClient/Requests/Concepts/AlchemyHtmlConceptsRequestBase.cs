using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyHtmlConceptsRequestBase : AlchemyConceptsRequestBase
    {
        protected const string sourceTextKey = "sourceText";
        protected const string cqueryKey = "cquery";
        protected const string xpathKey = "xpath";
        protected AlchemyHtmlConceptsRequestBase(AlchemyClient client):base(client)
        {


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
