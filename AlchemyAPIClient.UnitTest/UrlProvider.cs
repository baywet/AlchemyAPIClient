using System;
using System.Collections.Generic;

namespace AlchemyAPIClient.UnitTest
{
    public class UrlProvider
    {
        public static Lazy<List<Uri>> Uris = new Lazy<List<Uri>>(() =>
        {
            var result = new List<Uri>();
            result.Add(new Uri("http://www.cnn.com/2015/04/25/asia/nepal-earthquake-7-5-magnitude/index.html"));
            return result;
        });
    }
}
