using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyRawTextRequestBase : AlchemyTextRequestBase
    {
        public AlchemyRawTextRequestBase(AlchemyClient client)
            : base(client)
        {

        }
    }
}
