﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests.Text
{
    public class AlchemyHtmlCleanTextRequest : AlchemyCleanTextRequestBase
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlCleanTextRequest(string html, AlchemyClient client): base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetText"; }
        }
    }
}