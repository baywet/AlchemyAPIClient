using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemyObject
    {
        public string Text { get; set; }
        public AlchemySentiment Sentiment { get; set; }
        public AlchemySentiment SentimentFromSubject { get; set; }
        public AlchemyEntity Entity { get; set; }
    }
}
