using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class LanguageTest
    {
        [TestMethod]
        public void GetLanguageFromText()
        {
            var responses = new List<AlchemyLanguageResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextLanguageRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Select(x => x.Language).Any(x => !string.IsNullOrEmpty(x)));
        }
        [TestMethod]
        public void GetLanguageFromUrl()
        {
            var responses = new List<AlchemyLanguageResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlLanguageRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Select(x => x.Language).Any(x => !string.IsNullOrEmpty(x)));
        }
    }
}
