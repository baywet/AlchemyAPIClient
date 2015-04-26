using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlEntitiesRequest : AlchemyHtmlEntitiesRequestBase
    {
        protected override string RequestPath
        {
            get { return "url/URLGetRankedNamedEntities"; }
        }
        public AlchemyUrlEntitiesRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            if (url == null)
                throw new ArgumentNullException("url");
            Url = url;
        }
    }
}
