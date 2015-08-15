using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class TextTest
    {
        [TestMethod]
        public void GetTextFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlCleanTextRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                        ExtractLinks = true,
                        UseMetadata = true
                    };
                var response = Utilities.getRequestResult(request);
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(response.Text));
            }
        }
    }
}
