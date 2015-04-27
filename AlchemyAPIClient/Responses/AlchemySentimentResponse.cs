using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemySentimentResponse : AlchemyResponseBase<AlchemySentiment>
    {
        public AlchemySentiment DocSentiment { get; set; }
    }
}
