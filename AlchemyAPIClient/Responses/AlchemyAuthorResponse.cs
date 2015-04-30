using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyAuthorResponse : AlchemyResponseBase<string>
    {
        public string Author { get; set; }
    }
}
