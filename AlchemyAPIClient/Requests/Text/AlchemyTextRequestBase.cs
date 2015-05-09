using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyTextRequestBase : AlchemyRequestBase<string, AlchemyTextResponse>
    {
        protected const string urlKey = "url";
        public AlchemyTextRequestBase(AlchemyClient client)
            : base(client)
        {
            
        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
