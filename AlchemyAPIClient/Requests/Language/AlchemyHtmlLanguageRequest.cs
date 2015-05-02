﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlLanguageRequest : AlchemyHtmlLanguageRequestBase
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlLanguageRequest(string html, AlchemyClient client)
            : base(client)
        {
            if (string.IsNullOrWhiteSpace(html))
                throw new ArgumentNullException("html");
            Html = html;
        }
        protected override string RequestPath
        {
            get { return "html/HTMLGetLanguage"; }
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
