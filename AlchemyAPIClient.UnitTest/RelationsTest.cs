using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Responses;
using AlchemyAPIClient.Requests;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class RelationsTest
    {
        [TestMethod]
        public void GetRelationsFromText()
        {
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
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Relations);
            }
        }
        [TestMethod]
        public void GetRelationsFromUrl()
        {
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
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Relations);
            }
        }
    }
}
