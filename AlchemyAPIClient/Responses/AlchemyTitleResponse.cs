using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyTitleResponse : AlchemyResponseBase<string>
    {
        public string Title { get; set; }
    }
}
