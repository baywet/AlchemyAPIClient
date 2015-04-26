using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AlchemyAPIClient.Responses;
using AlchemyAPIClient.Requests;

namespace AlchemyAPIClient
{
    public class AlchemyClient
    {
        public string EndPointUrl { get; private set; }
        public string EndPointKey { get; private set; }
        public AlchemyClient(string endPointKey, string endPointUrl = "http://access.alchemyapi.com/calls/")
        {
            EndPointUrl = endPointUrl;
            EndPointKey = endPointKey;
        }
    }
}
