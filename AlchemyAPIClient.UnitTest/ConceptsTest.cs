using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class ConceptsTest
    {
        [TestMethod]
        public void GetConceptsFromText()
        {
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextConceptsRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        KnowledgeGraph = true,
                        LinkedData = true,
                        ShowSourceText = true,
                        MaxRetrieve = 30,
                    };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Concepts);
            }
        }
        [TestMethod]
        public void GetConceptsFormUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlConceptsRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        KnowledgeGraph = true,
                        LinkedData = true,
                        ShowSourceText = true,
                        MaxRetrieve = 30,
                    };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Concepts);
            }
        }
    }
}
