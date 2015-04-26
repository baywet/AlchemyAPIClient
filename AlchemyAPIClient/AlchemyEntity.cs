using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemyEntity
    {
        public string Type { get; set; }
        public double Relevance { get; set; }
        public uint Count { get; set; }
        public string Text { get; set; }
        public AlchemySentiment Sentiment { get; set; }
        public AlchemyGraph KnowledgeGraph { get; set; }
        public AlchemyDisambiguation Disambiguated { get; set; }
        public List<AlchemyQuotation> Quotations { get; set; }
    }
}
