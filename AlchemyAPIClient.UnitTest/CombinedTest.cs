using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests.Combined;
using System.Collections.Generic;
using AlchemyAPIClient.Requests;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class CombinedTest
    {
        [TestMethod]
        public void GetCombinedFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlCombinedRequest(AlchemyClientProvider.AlchemyClient.Value, new List<IAlchemyAPIUrlCombinableRequest>(){
                    new AlchemyUrlAuthorRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlTitleRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlEntitiesRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlKeywordsRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlConceptsRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlRelationsRequest(url,AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlSentimentRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlTaxonomiesRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                })
                {
                };
                var response = Utilities.getRequestResult(request);
                Assert.IsNotNull(response.AuthorResponse);
                Assert.IsNotNull(response.EntitiesResponse);
                Assert.IsNotNull(response.KeywordsResponse);
                Assert.IsNotNull(response.ConceptsResponse);
                Assert.IsNotNull(response.TaxonomiesResponse);
                Assert.IsNotNull(response.RelationResponse);
                Assert.IsNotNull(response.SentimentResponse);
                Assert.IsNotNull(response.TitleResponse);
            }
        }
        [TestMethod]
        public void GetCombinedFromText()
        {
            foreach (var text in DocumentsProvider.Documents.Value)
            {
                var request = new AlchemyTextCombinedRequest(AlchemyClientProvider.AlchemyClient.Value, new List<IAlchemyAPITextCombinableRequest>(){
                    new AlchemyTextEntitiesRequest(text, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyTextKeywordsRequest(text, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyTextConceptsRequest(text, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyTextRelationsRequest(text,AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyTextSentimentRequest(text, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyTextTaxonomiesRequest(text, AlchemyClientProvider.AlchemyClient.Value)
                })
                {
                };
                var response = Utilities.getRequestResult(request);
                Assert.IsNotNull(response.EntitiesResponse);
                Assert.IsNotNull(response.KeywordsResponse);
                Assert.IsNotNull(response.ConceptsResponse);
                Assert.IsNotNull(response.TaxonomiesResponse);
                Assert.IsNotNull(response.RelationResponse);
                Assert.IsNotNull(response.SentimentResponse);
            }
        }
    }
}
