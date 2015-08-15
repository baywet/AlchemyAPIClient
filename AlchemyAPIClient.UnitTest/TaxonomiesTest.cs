using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Responses;
using AlchemyAPIClient.Requests;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class TaxonomiesTest
    {
        [TestMethod]
        public void GetTaxonomiesFromText()
        {
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextTaxonomiesRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                var response = Utilities.getRequestResult(request);
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Taxonomy);
            }
        }
        [TestMethod]
        public void GetTaxonomiesFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlTaxonomiesRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                var response = Utilities.getRequestResult(request);
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Taxonomy);
            }    
        }
    }
}
