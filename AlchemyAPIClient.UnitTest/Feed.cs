using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class Feed
    {
        [TestMethod]
        public void GetFeedFromUrl()
        {
            var responses = new List<AlchemyFeedResponse>();
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlFeedRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                responses.Add(Utilities.getRequestResult(request));
            }
            Assert.IsTrue(responses.Select(x => x.Status).All(x => x == AlchemyAPIResponseStatus.OK));
            Assert.IsTrue(responses.SelectMany(x => x.Feeds).Any());
            Assert.IsTrue(responses.SelectMany(x => x.Feeds).First().Feed != default(Uri));
        }
    }
}
