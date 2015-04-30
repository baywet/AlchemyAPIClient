﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyUrlAuthorsRequest: AlchemyAuthorsRequestBase
    {
        public AlchemyUrlAuthorsRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            if (url == null)
                throw new ArgumentNullException("url");
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetAuthors"; }
        }
    }
}
