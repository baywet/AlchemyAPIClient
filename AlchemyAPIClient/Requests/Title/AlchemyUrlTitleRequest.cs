﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests.Title
{
    public class AlchemyUrlTitleRequest : AlchemyTitleRequestBase
    {
        public AlchemyUrlTitleRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetTitle"; }
        }
    }
}