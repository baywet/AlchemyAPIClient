using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Responses;
using AlchemyAPIClient.Requests;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class TaxonomiesTest
    {
        [TestMethod]
        public void GetTaxonomiesFromText()
        {
            var responses = new List<AlchemyTaxonomiesResponse>();
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextTaxonomiesRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.Taxonomy != null));
        }
        [TestMethod]
        public void GetTaxonomiesFromUrl()
        {
            var responses = new List<AlchemyTaxonomiesResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlTaxonomiesRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.Taxonomy != null));
        }
    }
}
