using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextRelationsRequest : AlchemyRelationsRequestBase
    {
        protected const string textKey = "text";
        public AlchemyTextRelationsRequest(string text, AlchemyClient client):base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
        protected override string RequestPath
        {
            get { return "text/TextGetRelations"; }
        }
    }
}
