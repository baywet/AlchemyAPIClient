using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class AuthorsTest
    {
        [TestMethod]
        public void GetAuthorsFromUrl()
        {
            var responses = new List<AlchemyAuthorsResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlAuthorsRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                responses.Add( Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x== AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Authors.Names).Any(x => !string.IsNullOrEmpty(x)));
        }
    }
}
