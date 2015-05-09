using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyHtmlRelationsRequestBase : AlchemyRelationsRequestBase
    {
        public AlchemyHtmlRelationsRequestBase (AlchemyClient client):base(client)
        {

        }
    }
}
