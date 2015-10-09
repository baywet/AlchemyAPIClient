using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests.Combined;
using System.Collections.Generic;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class CombinedTest
    {
        [TestMethod]
        public void GetCombinedFromUrl()
        {
            var responses = new List<AlchemyCombinedResponse<IAlchemyAPIUrlCombinableRequest>>();
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
                    new AlchemyUrlTaxonomiesRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlPublicationDateRequest(url, AlchemyClientProvider.AlchemyClient.Value),
                    new AlchemyUrlFeedRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                })
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Select(x =>x.AuthorResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.EntitiesResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.KeywordsResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.ConceptsResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.TaxonomiesResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.RelationResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.SentimentResponse).Any());
            Assert.IsTrue(responses.Select(x =>x.TitleResponse).Any());
        }
        [TestMethod]
        public void GetCombinedFromText()
        {
            var responses = new List<AlchemyCombinedResponse<IAlchemyAPITextCombinableRequest>>();
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
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Select(x => x.EntitiesResponse).Any());
            Assert.IsTrue(responses.Select(x => x.KeywordsResponse).Any());
            Assert.IsTrue(responses.Select(x => x.ConceptsResponse).Any());
            Assert.IsTrue(responses.Select(x => x.TaxonomiesResponse).Any());
            Assert.IsTrue(responses.Select(x => x.RelationResponse).Any());
            Assert.IsTrue(responses.Select(x => x.SentimentResponse).Any());
        }
    }
}
