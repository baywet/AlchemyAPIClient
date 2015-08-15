using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class TitleTest
    {
        [TestMethod]
        public void GetTitleFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlTitleRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                     UseMetadata = true
                };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(response.Title));
            }
        }
    }
}
