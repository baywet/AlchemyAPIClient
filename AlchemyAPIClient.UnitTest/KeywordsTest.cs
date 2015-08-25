using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class KeywordsTest
    {
        [TestMethod]
        public void GetKeywordsFromText()
        {
            var responses = new List<AlchemyKeywordsResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextKeywordsRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                {
                    KnowledgeGraph = true,
                    ShowSourceText = true,
                    MaxRetrieve = 30,
                    Sentiment = true,
                    KeyWordExtractModeText = KeyWordExtractModeType.Normal,
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Keywords).Any());
        }
        [TestMethod]
        public void GetKeywordsFromUrl()
        {
            var responses = new List<AlchemyKeywordsResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlKeywordsRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                    KnowledgeGraph = true,
                    ShowSourceText = true,
                    MaxRetrieve = 30,
                    Sentiment = true,
                    KeyWordExtractModeText = KeyWordExtractModeType.Normal,
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Keywords).Any());
        }
    }
}
