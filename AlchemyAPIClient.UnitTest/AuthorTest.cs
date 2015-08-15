using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void GetAuthorFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlAuthorRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                var response = Utilities.getRequestResult(request);
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(response.Author)); 
            }
        }
    }
}
