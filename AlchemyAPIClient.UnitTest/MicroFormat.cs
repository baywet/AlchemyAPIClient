using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using AlchemyAPIClient.Requests;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class MicroFormat
    {
        [TestMethod]
        public void GetMicroFormatFromUrl()
        {
            var responses = new List<AlchemyMicroFormatResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlMicroFormatRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
        }
    }
}
