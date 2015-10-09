using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class SentimentTest
    {
        [TestMethod]
        public void GetSentimentFromText()
        {
            var responses = new List<AlchemySentimentResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextSentimentRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                {
                    ShowSourceText = true,
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.DocSentiment != null));
        }
        [TestMethod]
        public void GetSentimentFromUrl()
        {
            var responses = new List<AlchemySentimentResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlSentimentRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                    ShowSourceText = true,
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.DocSentiment != null));
        }
    }
}
