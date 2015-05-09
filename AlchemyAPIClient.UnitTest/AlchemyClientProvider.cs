using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
