using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlRelationsRequest : AlchemyHtmlRelationsRequestBase
    {
        public AlchemyUrlRelationsRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { throw new NotImplementedException(); }
        }
    }
}
