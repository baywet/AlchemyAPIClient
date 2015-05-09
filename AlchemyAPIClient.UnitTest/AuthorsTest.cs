﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class AuthorsTest
    {
        [TestMethod]
        public void GetAuthorsFromUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlAuthorsRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                    {
                    };
                var requestTask = request.GetResponse();
                var awaiter = requestTask.GetAwaiter();
                var response = awaiter.GetResult();
                Assert.AreEqual(response.Status, AlchemyAPIResponseStatus.OK);
                Assert.IsNotNull(response.Authors); 
            }
        }
    }
}