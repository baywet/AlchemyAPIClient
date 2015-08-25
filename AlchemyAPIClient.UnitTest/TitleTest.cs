using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class TitleTest
    {
        [TestMethod]
        public void GetTitleFromUrl()
        {
            var responses = new List<AlchemyTitleResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlTitleRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                    UseMetadata = true
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Any(x => !string.IsNullOrWhiteSpace(x.Title)));
        }
    }
}
