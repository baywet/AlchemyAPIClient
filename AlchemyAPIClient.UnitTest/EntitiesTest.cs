using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class EntitiesTest
    {
        [TestMethod]
        public void GetEntitiesFromText()
        {
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
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Entities);
            }
        }
        [TestMethod]
        public void GetEntitiesFromUrl()
        {
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
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Entities);
            }
        }
    }
}
