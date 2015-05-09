using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class SentimentTest
    {
        [TestMethod]
        public void GetSentimentFromText()
        {
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextSentimentRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        ShowSourceText = true,
                    };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.DocSentiment); 
            }
        }
        [TestMethod]
        public void GetSentimentFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlSentimentRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        ShowSourceText = true,
                    };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.DocSentiment);  
            }
        }
    }
}
