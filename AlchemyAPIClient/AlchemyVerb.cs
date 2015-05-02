using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemyVerb
    {
        public string Text { get; set; }
        public bool Negated { get; set; }
        public AlchemyVerbTense Tense { get; set; }
    }
    public enum AlchemyVerbTense
    {
        Past,
        Present,
        Future
    }
}
