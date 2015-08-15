using System;
using System.Configuration;

namespace AlchemyAPIClient.UnitTest
{
    public class AlchemyClientProvider
    {
        public static Lazy<AlchemyClient> AlchemyClient = new Lazy<AlchemyClient>(() =>
        {
            return new AlchemyClient(ConfigurationManager.AppSettings["AlchemyEndPointKey"]);
        });
    }
}
