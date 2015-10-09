using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class EntitiesTest
    {
        [TestMethod]
        public void GetEntitiesFromText()
        {
            var responses = new List<AlchemyEntitiesResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextEntitiesRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                {
                    Coreference = true,
                    Disambiguate = true,
                    KnowledgeGraph = true,
                    LinkedData = true,
                    Quotations = true,
                    Sentiment = true,
                    ShowSourceText = true,
                    StructuredEntities = true,
                    MaxRetrieve = 30
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Entities).Any());
        }
        [TestMethod]
        public void GetEntitiesFromUrl()
        {
            var responses = new List<AlchemyEntitiesResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlEntitiesRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                    Coreference = true,
                    Disambiguate = true,
                    KnowledgeGraph = true,
                    LinkedData = true,
                    Quotations = true,
                    Sentiment = true,
                    ShowSourceText = true,
                    StructuredEntities = true,
                    MaxRetrieve = 30
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Entities).Any());
        }
    }
}
