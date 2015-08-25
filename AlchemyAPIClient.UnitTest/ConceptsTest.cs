using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class ConceptsTest
    {
        [TestMethod]
        public void GetConceptsFromText()
        {
            var responses = new List<AlchemyConceptsResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextConceptsRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        KnowledgeGraph = true,
                        LinkedData = true,
                        ShowSourceText = true,
                        MaxRetrieve = 30,
                    };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Concepts).Any());
        }
        [TestMethod]
        public void GetConceptsFormUrl()
        {
            var responses = new List<AlchemyConceptsResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlConceptsRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        KnowledgeGraph = true,
                        LinkedData = true,
                        ShowSourceText = true,
                        MaxRetrieve = 30,
                    };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Concepts).Any());
        }
    }
}
