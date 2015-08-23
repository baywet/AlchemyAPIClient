using AlchemyAPIClient.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.UnitTest
{
    [TestClass]
    public class PublicationDateTests
    {
        [TestMethod]
        public void GetPublicationDateFormUrl()
        {
            foreach (var url in UrlProvider.Uris.Value)
            {
                var request = new AlchemyUrlPublicationDateRequest(url, AlchemyClientProvider.AlchemyClient.Value)
                {
                };
                var response = Utilities.getRequestResult(request);
                Assert.IsNotNull(response.PublicationDate);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(response.PublicationDate.Date));
                Assert.IsTrue(response.PublicationDate.FormattedDate != default(DateTime));
            }
        }
    }
}
