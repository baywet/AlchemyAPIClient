using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class PublicationDateTests
    {
        [TestMethod]
        public void GetPublicationDateFormUrl()
        {
            var responses = new List<AlchemyPublicationDateResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlPublicationDateRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.All(x => x.PublicationDate != null));
            Assert.IsTrue(responses.Select(x => x.PublicationDate.Date).Any(x => !string.IsNullOrWhiteSpace(x)));
            Assert.IsTrue(responses.Select(x => x.PublicationDate.FormattedDate).Any(x => x != default(DateTime)));
        }
    }
}
