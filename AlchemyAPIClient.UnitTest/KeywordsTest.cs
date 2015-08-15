using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class KeywordsTest
    {
        [TestMethod]
        public void GetKeywordsFromText()
        {
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
                var response = Utilities.getRequestResult(request);
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Keywords); 
            }
        }
        [TestMethod]
        public void GetKeywordsFromUrl()
        {
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
                var response = Utilities.getRequestResult(request);
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Keywords);  
            }
        }
    }
}
