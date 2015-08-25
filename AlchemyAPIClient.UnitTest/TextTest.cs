using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class TextTest
    {
        [TestMethod]
        public void GetTextFromUrl()
        {
            var responses = new List<AlchemyTextResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlCleanTextRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                    ExtractLinks = true,
                    UseMetadata = true
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Any(x => !string.IsNullOrWhiteSpace(x.Text)));
        }
    }
}
