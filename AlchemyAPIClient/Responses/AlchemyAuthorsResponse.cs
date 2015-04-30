using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyAuthorsResponse : AlchemyResponseBase<List<string>>
    {
        public List<string> Authors { get; set; }
    }
}
