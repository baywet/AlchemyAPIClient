using System;
using System.Collections.Generic;

namespace AlchemyAPIClient.UnitTest
{
    public class UrlProvider
    {
        public static Lazy<List<Uri>> Uris = new Lazy<List<Uri>>(() =>
        {
            return new List<Uri> {
                new Uri("http://www.cnn.com/2015/04/25/asia/nepal-earthquake-7-5-magnitude/index.html"),
                new Uri("http://microsofttouch.fr/english/b/vince365/archive/2015/08/18/net-library-for-alchemy-api")
            };
        });
    }
}
