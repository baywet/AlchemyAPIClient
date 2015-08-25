using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using System.Collections.Generic;
using System.Linq;
using AlchemyAPIClient.Exceptions;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void GetAuthorFromUrl()
        {
            var responses = new List<AlchemyAuthorResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                try
                {
                    var request = new AlchemyUrlAuthorRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                    responses.Add(Utilities.getRequestResult(request));
                }
                catch (AlchemyAPIMultipleAuthorCandidatesException)
                { }
                catch (AlchemyAPICannotLocateAuthorException)
                {
                    //Swallowing these ones because it can happen on regular docs
                }
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.Select(x => x.Author).Any(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
