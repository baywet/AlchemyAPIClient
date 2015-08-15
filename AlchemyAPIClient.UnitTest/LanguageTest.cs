using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class LanguageTest
    {
        [TestMethod]
        public void GetLanguageFromText()
        {
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextLanguageRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Language);
            }
        }
        [TestMethod]
        public void GetLanguageFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlLanguageRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Language);
            }
        }
    }
}
