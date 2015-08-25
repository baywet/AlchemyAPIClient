using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Responses;
using AlchemyAPIClient.Requests;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class RelationsTest
    {
        [TestMethod]
        public void GetRelationsFromText()
        {
            var responses = new List<AlchemyRelationsResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextRelationsRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                {
                    Coreference = true,
                    Entities = true,
                    RequireEntities = true,
                    Disambiguate = true,
                    LinkedData = true,
                    Keywords = true,
                    MaxRetrieve = 40,
                    Sentiment = true,
                    ShowSourceText = true
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.Relations != null));
        }
        [TestMethod]
        public void GetRelationsFromUrl()
        {
            var responses = new List<AlchemyRelationsResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlRelationsRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                    Coreference = true,
                    Entities = true,
                    RequireEntities = true,
                    Disambiguate = true,
                    LinkedData = true,
                    Keywords = true,
                    MaxRetrieve = 40,
                    Sentiment = true,
                    ShowSourceText = true
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.Relations != null));
        }
    }
}
